#include "pch.h"
#include "Runtime.h"
#include "Engine\UClass.h"
#include "Engine\UProperty.h"
#include "Engine\GameOffsets.h"
#include "Engine\GameFunctions.h"
#include "Framework\ClassInfo.h"
#include "Printer\Printer.h"

#include <cstdint>
#include <fstream>
#include <thread>
#include <atomic>
#include <regex>

uintptr_t Runtime::BaseAddress = 0;
DWORD Runtime::MainThreadId = 0;

TArray<UObject*>* Runtime::GObjects = 0;
TArray<FNameEntry*>* Runtime::GNames = 0;
vector<ClassInfo> Runtime::Classes = {};

void Runtime::OnAttach()
{
    // Setup debug console
    Debug::Init();

    // Find base address
    Runtime::BaseAddress = (uintptr_t)(GetModuleHandle(NULL));

    // Bail out on unsupported builds rather than reading bogus addresses
    if (!GameOffsets::Init(Runtime::BaseAddress))
    {
        TRACE("Unrecognized BatmanAC.exe build, aborting");
        return;
    }

    // Get the main thread Id
    Runtime::MainThreadId = GetCurrentThreadId();

    // Set global pointers
    Runtime::GObjects = (TArray<UObject*>*) (Runtime::BaseAddress + GameOffsets::GObjects);
    Runtime::GNames = (TArray<FNameEntry*>*) (Runtime::BaseAddress + GameOffsets::GNames);
    GameFunctions::Init(Runtime::BaseAddress);

    // Wait for keypress in another thread
    std::thread(
        []()
        {
            TRACE("Press 'P' to start SDK generation");
            while (true)
            {
                if ((GetAsyncKeyState('P') & 0x8000))
                {
                    DWORD foregroundPID = 0;
                    GetWindowThreadProcessId(GetForegroundWindow(), &foregroundPID);

                    // Don't generate if the game window isn't focused.
                    if (foregroundPID != GetCurrentProcessId())
                    {
                        continue;
                    }

                    HANDLE mainThread = OpenThread(THREAD_SUSPEND_RESUME, FALSE, Runtime::MainThreadId);
                    if (mainThread) SuspendThread(mainThread);

                    Runtime::GenerateSDK();

                    if (mainThread) {
                        ResumeThread(mainThread);
                        CloseHandle(mainThread);
                    }
                    break;
                }
                this_thread::sleep_for(chrono::milliseconds(100));
            }
        })
        .detach();
}

void Runtime::LoadClassesIntoMemory() {
    TRACE("Loading all UPKs into memory");

    const wregex packageFilter(
        L"(?:"
        // These packages are always loaded
        // exact match these names
        L"^Core$|^Engine$|^BmGame$|^OnlineSubsystem|"
        // These packages never contain classes
        // match if these are present anywhere
        L"ShaderCache|"
        // match if these are at the start
        L"^Anim_|^Bio_|^CS_|^CV_|^Dlg-|^LH-|^WwSpch-|^Tape|^Synopsis|^Gallery"
        L")",
        regex_constants::icase);

    const auto upkDir = fs::path{ "." } / ".." / ".." / "BmGame" / "CookedPCConsole";
    for (const auto& entry : fs::directory_iterator(upkDir)) {
        if (!entry.is_regular_file()) continue;	// filter files
        if (entry.path().extension() != ".upk") continue;	// filter UPKs
        auto name = entry.path().stem().wstring();

        // Filter packages that are only for assets
        if (regex_search(name, packageFilter)) continue;

        GameFunctions::LoadPackage(0, name.c_str(), 0);
    }
    TRACE("Done loading packages");
}

void Runtime::GenerateSDK()
{
    TRACE("Preparing SDK generation");

    LoadClassesIntoMemory();

    TRACE("Scanning {} objects for classes", Runtime::GObjects->Num);

    Runtime::Classes.clear();
    for (INT i = 0; i < Runtime::GObjects->Num; i++)
    {
        auto obj = Runtime::GObjects->ElementAt(i);

        bool isValid = obj != nullptr && (Runtime::GObjects->ElementAt(obj->Index) == obj);
        if (!isValid)
        {
            continue;
        }

        // Collect class objects (but not the CDO)
        if (obj->Class == UClass::StaticClass() &&
            !(obj->ObjectFlags & (QWORD)EObjectFlags::RF_ClassDefaultObject))
        {
            Runtime::Classes.emplace_back((UClass*)obj);
        }
    }

    // Clear output directory
    TRACE("Found {} classes, preparing to print", Classes.size());
    for (auto& classObj : Classes)
    {
        classObj.ResolveSuper(Classes);
    }

    // TODO: Un-hardcode this
    fs::path outDir = "..\\..\\..\\src\\BmSDK\\Generated\\";
    fs::remove_all(outDir);
    fs::create_directory(outDir);

    // Print some classes
    for (auto i = 0u; i < Classes.size(); i++)
    {
        auto& classObj = Classes.at(i);
        auto classFilePath =
            outDir / classObj.PackageName / (classObj.ManagedName + ".g.cs");

        if (!fs::exists(classFilePath.parent_path()) &&
            fs::exists(classFilePath.parent_path().parent_path()))
        {
            TRACE("Creating output subdir {}", classFilePath.parent_path().filename().string());
            fs::create_directories(classFilePath.parent_path());
        }

        ofstream classFileStream(classFilePath, ios::trunc | ios::binary);
        if (!classFileStream.is_open())
        {
            TRACE("Couldn't open file {}", classFilePath.string());
            continue;
        }

        Printer::PrintFile(classObj, classFileStream);
    }

    // Print StaticInit file
    ofstream staticInitFileStream(outDir / "StaticInit.g.cs", ios::trunc | ios::binary);
    Printer::PrintStaticInit(Classes, staticInitFileStream);

    TRACE("Done writing {} classes to disk", Classes.size());

    // Exit game early
    exit(0);
    return;
}

BOOL APIENTRY DllMain(HMODULE hModule, DWORD ul_reason_for_call, LPVOID lpReserved)
{
    switch (ul_reason_for_call)
    {
        case DLL_PROCESS_ATTACH:
            Runtime::OnAttach();
            break;
        case DLL_THREAD_ATTACH:
        case DLL_THREAD_DETACH:
        case DLL_PROCESS_DETACH:
            break;
    }
    return TRUE;
}
