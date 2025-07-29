#include "problem_2894.h"

#include <cmath>

bool problem_2894::test() {
    int n = 10;
    int m = 3;

    int expected = 19;

    auto result = differenceOfSums(n, m);

    std::cout << result << std::endl;
    return result == expected;
}

int problem_2894::differenceOfSums(int n, int m) {
    int num = std::floor(n / m);

    return ((n * (n + 1) / 2)) - ((num * (num + 1)) / 2) * 2 * m;
}
