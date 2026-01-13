#include "problem_2466.h"

bool problem_2466::test() {
    int low = 2;
    int high = 3;
    int zero = 1;
    int one = 2;

    int expected = 5;

    auto result = countGoodStrings(low, high, zero, one);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2466::countGoodStrings(int low, int high, int zero, int one) {
    std::vector dp(high + 1, 0);
    dp[0] = 1;
    int big = std::max(zero, one);
    int smal = std::min(zero, one);
    int mod = 1000000007;
    long long result = 0;
    for (int i = smal; i <= high; ++i)
    {
        dp[i] += dp[i - smal] % mod;
        if (i >= big)
            dp[i] += dp[i - big] % mod;
        if (i >= low)
        {
            result = (result + dp[i]) % mod;
        }
    }

    return (int)result;
}
