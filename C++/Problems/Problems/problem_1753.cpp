#include "problem_1753.h"

bool problem_1753::test() {
    int a = 4;
    int b = 4;
    int c = 6;

    int expected = 7;

    auto result = maximumScore(a, b, c);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1753::maximumScore(int a, int b, int c) {
    int big = std::max(a, std::max(b, c));
    int total = a + b + c;
    int rest = total - big;
    return std::min(big, rest) + std::max(0, (rest - big) / 2);
}
