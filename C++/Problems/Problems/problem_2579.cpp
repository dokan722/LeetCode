#include "problem_2579.h"

bool problem_2579::test() {
    int n = 2;

    long expected = 5;

    auto result = coloredCells(n);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2579::coloredCells(int n) {
    return (long long)(n - 1) * n / 2 * 4 + 1;
}
