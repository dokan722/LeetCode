#include "problem_2481.h"

bool problem_2481::test() {
    int n = 4;

    int expected = 2;

    auto result = numberOfCuts(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2481::numberOfCuts(int n) {
    if (n == 1)
        return 0;
    return n % 2 == 0 ? n / 2 : n;
}
