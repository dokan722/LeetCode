#include "problem_231.h"

bool problem_231::test() {
    auto n = 16;

    auto expected = true;

    auto result = isPowerOfTwo(n);

    return result == expected;
}

bool problem_231::isPowerOfTwo(int n) {
    if (n <= 0)
        return false;

    while (n > 1)
    {
        auto mod = n % 2;
        if (mod == 1)
            return false;
        n >>= 1;
    }

    return true;
}
