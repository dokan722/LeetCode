#include "problem_3870.h"

bool problem_3870::test() {
    int n = 1002;

    int expected = 3;

    auto result = countCommas(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3870::countCommas(int n) {
    return std::max(n - 999, 0);
}
