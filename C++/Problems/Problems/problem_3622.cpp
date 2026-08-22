#include "problem_3622.h"

bool problem_3622::test() {
    int n = 99;

    bool expected = true;

    auto result = checkDivisibility(n);

    return result == expected;
}

bool problem_3622::checkDivisibility(int n) {
    int prod = 1;
    int s = 0;
    int num = n;
    while (num > 0)
    {
        int d = num % 10;
        prod *= d;
        s += d;
        num /= 10;
    }

    return n % (s + prod) == 0;
}
