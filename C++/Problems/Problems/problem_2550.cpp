#include "problem_2550.h"

bool problem_2550::test() {
    int n = 3;

    int expected = 6;

    auto result = monkeyMove(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2550::monkeyMove(int n) {
    long result = 1;
    long b = 2;
    int mod = 1000000007;
    while (n > 0)
    {
        if (n % 2 == 1)
            result = result * b % mod;
        b = b * b % mod;
        n /= 2;
    }

    return (int)(result - 2 + mod) % mod;
}
