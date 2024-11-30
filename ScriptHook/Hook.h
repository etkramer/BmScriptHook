#pragma once

class Hook {
private:
    Hook() = delete;

public:
    static void Init();
    static void RunTests();
};