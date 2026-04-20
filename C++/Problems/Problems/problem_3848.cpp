#include "problem_3848.h"

bool problem_3848::test() {
    int n = 145;

    bool expected = true;

    auto result = isDigitorialPermutation(n);

    return expected == result;
}

bool problem_3848::isDigitorialPermutation(int n) {
    std::vector factorials  { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
    int fs = 0;
    std::vector counts(10, 0);
    while (n > 0)
    {
        int digit = n % 10;
        fs += factorials[digit];
        counts[digit]++;
        n /= 10;
    }
    while (fs > 0)
    {
        counts[fs % 10]--;
        fs /= 10;
    }
    for (int i = 0; i < 10; ++i)
    {
        if (counts[i] != 0)
            return false;
    }

    return true;
}
