#include "problem_326.h"

bool problem_326::test() {
    auto n = 27;

    auto expected = true;

    auto result = isPowerOfThree(n);

    return expected == result;
}

bool problem_326::isPowerOfThree(int n) {
    if (n < 1)
        return false;
    while (n > 1)
    {
        if (n % 3 != 0)
            return false;
        n /= 3;
    }

    return true;
}
