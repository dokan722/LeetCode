#include "problem_461.h"

bool problem_461::test() {
    auto x = 1;
    auto y = 4;

    auto expected = 2;

    auto result = hammingDistance(x, y);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_461::hammingDistance(int x, int y) {
    return std::popcount((unsigned)(x ^ y));
}
