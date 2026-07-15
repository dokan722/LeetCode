#include "problem_3856.h"

bool problem_3856::test() {
    int n = 4;

    int expected = 4;

    auto result = gcdOfOddEvenSums(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3856::gcdOfOddEvenSums(int n) {
    return n;
}
