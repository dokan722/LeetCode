#include "problem_1780.h"

bool problem_1780::test() {
    int n = 91;

    bool expected = true;

    auto result = checkPowersOfThree(n);

    return result == expected;
}

bool problem_1780::checkPowersOfThree(int n) {
    int curr = 1;
    while (curr <= n)
        curr *= 3;

    while (n > 0)
    {
        if (n >= curr)
            n -= curr;
        if (n >= curr)
            return false;
        curr /= 3;
    }

    return true;
}
