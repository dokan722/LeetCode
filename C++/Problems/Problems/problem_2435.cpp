#include "problem_2435.h"

bool problem_2435::test() {
    std::vector<std::vector<int>> grid { { 5, 2, 4 }, { 3, 0, 5 }, { 0, 7, 2 } };
    int k = 3;

    int expected = 2;

    auto result = numberOfPaths(grid, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2435::numberOfPaths(std::vector<std::vector<int>> &grid, int k) {
    int n = grid.size();
    int m = grid[0].size();
    int mod = 1000000007;
    std::vector dp(n, std::vector(m, std::vector(k, 0)));

    dp[0][0][grid[0][0] % k] = 1;

    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            for (int l = 0; l < k; ++l)
            {
                dp[i][j][(l + grid[i][j]) % k] += ((i > 0 ? dp[i - 1][j][l] : 0) + (j > 0 ? dp[i][j - 1][l] : 0)) % mod;
            }
        }
    }

    return dp[n - 1][m - 1][0];
}
