#include "problem_650.h"

bool problem_650::test() {
    int n = 3;

    int expected = 3;

    auto result = minSteps(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_650::minSteps(int n) {
    std::vector dp(n + 1, INT_MAX);
    dp[1] = 0;
    for (int i = 2; i <= n; ++i)
    {
        for (int j = 1; j <= i / 2; j++)
        {
            if (i % j == 0)
                dp[i] = std::min(dp[i], dp[j] + i / j);
        }
    }

    return dp[n];
}
