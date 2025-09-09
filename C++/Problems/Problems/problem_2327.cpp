#include "problem_2327.h"

bool problem_2327::test() {
    int n = 6;
    int delay = 2;
    int forget = 4;

    int expected = 5;

    auto result = peopleAwareOfSecret(n, delay, forget);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2327::peopleAwareOfSecret(int n, int delay, int forget) {
    std::vector dp(n, 0);
    dp[0] = 1;
    long long share = 0;
    int mod = 1000000007;
    for (int i = 1; i < n; i++)
    {
        if (i - delay >= 0)
            share = (share + dp[i - delay] + mod) % mod;
        if (i - forget >= 0)
            share = (share - dp[i - forget] + mod) % mod;
        dp[i] = share;
    }

    long long know = 0;

    for (int i = n - forget; i < n; i++)
        know = (know + dp[i]) % mod;

    return (int)know;
}
