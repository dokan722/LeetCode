#include "problem_2787.h"

#include <cmath>

bool problem_2787::test() {
    int n = 64;
    int x = 3;

    int expected = 1;

    auto result = numberOfWays(n, x);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2787::numberOfWays(int n, int x) {
    int mod = 1000000007;
    std::vector poss(n + 1, 0);
    poss[0] = 1;
    for (int i = 1; i <= n; i++)
    {
        int val = std::pow(i, x);
        if (val > n)
            break;
        for (int j = n; j >= val; j--)
            poss[j] = (poss[j] + poss[j - val]) % mod;
    }
    return poss[n];
}
