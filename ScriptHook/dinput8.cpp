#include <unknwn.h>

using DirectInput8CreateFunc = HRESULT(__stdcall*)(
	HINSTANCE hinst,
	DWORD dwVersion,
	REFIID riidltf,
	LPVOID* ppvOut,
	LPUNKNOWN punkOuter
);

extern "C" {
	__declspec(dllexport) HRESULT __stdcall DirectInput8Create(HINSTANCE hinst, DWORD dwVersion, REFIID riidltf, LPVOID* ppvOut, LPUNKNOWN punkOuter) {
		#pragma comment(linker, "/EXPORT:" __FUNCTION__ "=" __FUNCDNAME__)

		static DirectInput8CreateFunc pDirectInput8Create;

		// Do we have a ptr to dinput8.dll!DirectInput8Create() yet? If not, load it
		if (!pDirectInput8Create) {
			// Find original dinput8.dll path
			char dllPath[MAX_PATH];
			GetSystemDirectoryA(dllPath, MAX_PATH);
			strcat_s(dllPath, "\\dinput8.dll");

			// Store a ptr to the original function
			HMODULE module = LoadLibraryA(dllPath);
			if (module) {
				pDirectInput8Create = (DirectInput8CreateFunc)GetProcAddress(module, "DirectInput8Create");
			}
		}

		// Call original impl
		if (pDirectInput8Create) {
			return pDirectInput8Create(hinst, dwVersion, riidltf, ppvOut, punkOuter);
		}

		return E_FAIL;
	}
}