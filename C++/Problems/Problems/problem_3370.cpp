#include "problem_3370.h"

bool problem_3370::test() {
    int n = 5;

    int expected = 7;

    auto result = smallestNumber(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3370::smallestNumber(int n) {
    int val = 2;
    while (val <= n)
        val <<= 1;

    return val - 1;
}
