#include "problem_3393.h"

bool problem_3393::test() {
    std::vector<std::vector<int>> grid { { 2, 1, 5 }, { 7, 10, 0 }, { 12, 6, 4 } };
    int k = 11;

    int expected = 3;

    auto result = countPathsWithXorValue(grid, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3393::countPathsWithXorValue(std::vector<std::vector<int>> &grid, int k) {
    int n = grid.size();
    int m = grid[0].size();
    int mod = 1000000007;
    int limit = 16;
    std::vector dp(n, std::vector(m, std::vector<long long>(limit, 0)));
    dp[0][0][grid[0][0]] = 1;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            for (int l = 0; l < limit; ++l)
            {
                int next = l ^ grid[i][j];
                int up = i > 0 ? dp[i - 1][j][l] : 0;
                int left = j > 0 ? dp[i][j - 1][l] : 0;
                dp[i][j][next] = (dp[i][j][next] + up + left) % mod;
            }
        }
    }

    return (int)dp[n - 1][m - 1][k];
}
