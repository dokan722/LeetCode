#include "problem_2749.h"

bool problem_2749::test() {
    int num1 = 3;
    int num2 = -2;

    int expected = 3;

    int result = makeTheIntegerZero(num1, num2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2749::makeTheIntegerZero(int num1, int num2) {
    for (int i = 1;; i++)
    {
        long next = num1 - i * (long long)num2;
        if (next < i)
            return -1;
        int count = std::popcount((unsigned long long)next);
        if (count <= i)
            return i;
    }
}
