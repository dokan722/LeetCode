#include "problem_2549.h"

bool problem_2549::test() {
    int n = 5;

    int expected = 4;

    auto result = distinctIntegers(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2549::distinctIntegers(int n) {
    return n == 1 ? 1 : n - 1;
}
