#include "problem_3754.h"

bool problem_3754::test() {
    int n = 10203004;

    long long expected = 12340;

    auto result = sumAndMultiply(n);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3754::sumAndMultiply(int n) {
    int x = 0;
    int s = 0;
    int cur = 1;
    while (n > 0)
    {
        int rem = n % 10;
        if (rem != 0)
        {
            x += rem * cur;
            s += rem;
            cur *= 10;
        }
        n = n /= 10;
    }

    return (long long)x * s;
}