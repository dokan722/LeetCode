#include "problem_3122.h"

bool problem_3122::test() {
    std::vector<std::vector<int>> grid = { { 1, 0, 2 },  { 1, 0, 2 } };

    int expected = 0;

    auto result = minimumOperations(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3122::minimumOperations(std::vector<std::vector<int>> &grid) {
    int cap = 10;
    int n = grid.size();
    int m = grid[0].size();
    std::vector dp(cap, 0);
    for (int i = 0; i < m; ++i)
    {
        std::vector counts(cap, 0);
        for (int j = 0; j < n; ++j)
            counts[grid[j][i]]++;
        std::vector next(cap, 10);
        for (int j = 0; j < cap; ++j)
        {
            int best = INT_MAX;
            for (int k = 0; k < cap; ++k)
            {
                if (k != j)
                    best = std::min(best, dp[k] + (n - counts[k]));
            }
            next[j] = best;
        }
        dp = next;
    }
    int result = INT_MAX;
    for (int i = 0; i < cap; ++i)
        result = std::min(dp[i], result);
    return result;
}
