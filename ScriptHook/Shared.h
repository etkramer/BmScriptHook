#pragma once

#define WIN32_LEAN_AND_MEAN
#include <windows.h>
#include <string>

#define TRACE(x, ...) OutputDebugStringA((std::format(x, __VA_ARGS__) + "\n").c_str())