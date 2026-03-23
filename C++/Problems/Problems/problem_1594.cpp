#include "problem_1594.h"

bool problem_1594::test() {
    std::vector<std::vector<int>> grid { { 1, -2, 1 }, { 1, -2, 1 }, { 3, -4, 1 } };

    int expected = 8;

    auto result = maxProductPath(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1594::maxProductPath(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int mod = 1000000007;
    std::vector dp(n, std::vector<std::pair<long long, long long>>(m, std::pair<long long, long long>(0, 0)));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (i == 0 && j == 0)
            {
                dp[i][j] = std::pair(grid[i][j], grid[i][j]);
                continue;
            }
            std::pair up = i > 0 ? dp[i - 1][j] : std::pair<long long, long long>(INT_MIN, INT_MAX);
            std::pair left = j > 0 ? dp[i][j - 1] : std::pair<long long, long long>(INT_MIN, INT_MAX);
            if (grid[i][j] >= 0)
            {
                dp[i][j] = std::pair<long long, long long>(std::max(grid[i][j] * up.first, grid[i][j] * left.first), std::min(grid[i][j] * up.second, grid[i][j] * left.second));
            }
            else
            {
                dp[i][j] = std::pair<long long, long long>(std::max(grid[i][j] * up.second, grid[i][j] * left.second), std::min(grid[i][j] * up.first, grid[i][j] * left.first));
            }
        }
    }

    return dp[n - 1][m - 1].first >= 0 ? (int)(dp[n - 1][m - 1].first % mod) : -1;
}
