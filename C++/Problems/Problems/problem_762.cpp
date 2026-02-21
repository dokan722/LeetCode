#include "problem_762.h"

bool problem_762::test() {
    int left = 6;
    int right = 10;


    int expected = 4;

    auto result = countPrimeSetBits(left, right);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_762::countPrimeSetBits(int left, int right) {
    int result = 0;
    for (int i = left; i <= right; ++i)
    {
        int bits = std::popcount((unsigned)i);
        if (bits == 2 || bits == 3 || bits == 5 || bits == 7 || bits == 11 || bits == 13 || bits == 17 || bits == 19)
            result++;
    }

    return result;
}
