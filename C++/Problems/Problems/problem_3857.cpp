#include "problem_3857.h"

bool problem_3857::test() {
    int n = 3;

    int expected = 3;

    auto result = minCost(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3857::minCost(int n) {
    return n * (n - 1) / 2;
}
