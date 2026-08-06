#include "problem_3345.h"

bool problem_3345::test() {
    int n = 10;
    int t = 2;

    int expected = 10;

    auto result = smallestNumber(n, t);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3345::smallestNumber(int n, int t) {
    for (int i = n; i <= n + 10 * t + 1; ++i)
    {
        int num = i;
        int prod = 1;
        while (num > 0)
        {
            prod *= num % 10;
            num /= 10;
        }
        if (prod % t == 0)
            return i;
    }

    return -1;
}
