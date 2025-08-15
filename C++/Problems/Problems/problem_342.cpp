#include "problem_342.h"

bool problem_342::test() {
    auto n = 16;

    auto expected = true;

    auto result = isPowerOfFour(n);

    return expected == result;
}

bool problem_342::isPowerOfFour(int n) {
    if (n < 1)
        return false;
    while (n > 1)
    {
        if (n % 4 != 0)
            return false;
        n /= 4;
    }

    return true;
}
