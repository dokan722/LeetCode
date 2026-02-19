#include "problem_3592.h"

bool problem_3592::test() {
    std::vector numWays  { 0, 1, 0, 2, 0, 3, 0, 4, 0, 5 };

    std::vector expected  { 2, 4, 6 };

    auto result = findCoins(numWays);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_3592::findCoins(std::vector<int> &numWays) {
    int n = numWays.size();
    std::vector dp(n + 1, 0);
    dp[0] = 1;
    std::vector<int> result;
    for (int i = 1; i <= n; ++i)
    {
        if (dp[i] != numWays[i - 1])
        {
            if (numWays[i - 1] - dp[i] != 1)
                return std::vector<int>();
            dp[i]++;
            for (int j = i + 1; j <= n; ++j)
            {
                dp[j] += dp[j - i];
            }
            result.push_back(i);
        }
    }

    return result;
}
