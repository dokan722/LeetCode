#include "problem_746.h"

bool problem_746::test() {
    std::vector cost { 10, 15, 20 };

    int expected = 15;

    auto result = minCostClimbingStairs(cost);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_746::minCostClimbingStairs(std::vector<int> &cost) {
    int n = cost.size();
    std::vector dp(n + 1, 0);
    for (int i = 2; i <= n; ++i)
        dp[i] = std::min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);

    return dp[n];
}
