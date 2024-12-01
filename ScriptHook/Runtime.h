#pragma once

class Runtime {
private:
    Runtime() = delete;

public:
    static void Init();

public:
    static uintptr_t BaseAddress;
};