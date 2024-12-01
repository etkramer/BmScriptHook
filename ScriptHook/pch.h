#pragma once

// Windows API
#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <string>
#include <format>

// SDK Headers
#include "GameDefines.hpp"
#include "SDK_HEADERS/Core_structs.hpp"
#include "SDK_HEADERS/Core_classes.hpp"
#include "SDK_HEADERS/Core_parameters.hpp"
#include "SDK_HEADERS/Engine_structs.hpp"
#include "SDK_HEADERS/Engine_classes.hpp"
#include "SDK_HEADERS/Engine_parameters.hpp"

#define TRACE(x, ...) OutputDebugStringA((std::format(x, __VA_ARGS__) + "\n").c_str())
#define ERROR(x, ...) TRACE(x, __VA_ARGS__); abort();