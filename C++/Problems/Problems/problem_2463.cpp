#include "problem_2463.h"

bool problem_2463::test() {
    std::vector robot  {0, 4, 6};
    std::vector<std::vector<int>> factory { { 2, 2 }, { 6, 2 } };

    int expected = 4;

    auto result = minimumTotalDistance(robot, factory);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2463::minimumTotalDistance(std::vector<int> &robot, std::vector<std::vector<int>> &factory) {
    std::sort(robot.begin(), robot.end());
    std::sort(factory.begin(), factory.end(), [](const std::vector<int>& a, const std::vector<int>& b) { return a[0] < b[0]; });
    int n = robot.size();
    int m = factory.size();

    std::vector dp(n + 1, std::vector<long long>(m + 1, LONG_LONG_MAX / (m + 1)));
    for (int i = 0; i <= m; ++i)
        dp[0][i] = 0;

    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= m; ++j)
        {
            dp[i][j] = dp[i][j - 1];
            int newPos = factory[j - 1][0];
            int newCap = factory[j - 1][1];
            long long acmDist = 0;
            for (int k = 1; k <= newCap && k <= i; ++k)
            {
                acmDist += std::abs((long long)newPos - robot[i - k]);
                dp[i][j] = std::min(dp[i][j], acmDist + dp[i - k][j - 1]);
            }
        }
    }
    return dp[n][m];
}
