#include "problem_319.h"

bool problem_319::test() {
    int n = 3;

    int expected = 1;

    auto result = bulbSwitch(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_319::bulbSwitch(int n) {
    return (int)std::sqrt(n);
}
