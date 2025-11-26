#include "problem_64.h"

bool problem_64::test() {
    std::vector<std::vector<int>> grid = { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } };

    int expected = 7;

    auto result = minPathSum(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_64::minPathSum(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector dp(n, std::vector(m, 0));
    dp[0][0] = grid[0][0];
    int j = 1;
    for (int i = 0; i < n; ++i)
    {
        for (; j < m; ++j)
            dp[i][j] = std::min(i > 0 ? dp[i - 1][j] : INT_MAX, j > 0 ? dp[i][j - 1] : INT_MAX) + grid[i][j];
        j = 0;

    }

    return dp[n - 1][m - 1];
}
