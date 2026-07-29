#include "problem_322.h"

bool problem_322::test() {
    std::vector coins { 1, 2, 5 };
    int amount = 11;

    int expected = 3;

    auto result = coinChange(coins, amount);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_322::coinChange(std::vector<int> &coins, int amount) {
    std::vector<int> dp(amount + 1);
    dp[0] = 0;
    for (int i = 1; i <= amount; ++i)
    {
        dp[i] = INT_MAX;
        for (auto c : coins)
        {
            int req = i - c;
            if (req >= 0 && dp[req] != INT_MAX)
                dp[i] = std::min(dp[i], dp[req] + 1);
        }
    }
    return dp[amount] == INT_MAX ? -1 : dp[amount];
}
