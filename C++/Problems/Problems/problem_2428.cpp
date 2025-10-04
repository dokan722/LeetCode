#include "problem_2428.h"

bool problem_2428::test() {
    std::vector<std::vector<int>> grid { { 6, 2, 1, 3 }, { 4, 2, 1, 5 }, { 9, 2, 8, 7 }, { 4, 1, 2, 9 } };

    int expected = 30;

    auto result = maxSum(grid);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2428::maxSum(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int result = 0;

    for (int i = 1; i < n - 1; ++i)
    {
        for (int j = 1; j < m - 1; ++j)
        {
            result = std::max(result, grid[i - 1][j - 1] + grid[i - 1][j] + grid[i - 1][j + 1] + grid[i][j] + grid[i + 1][j - 1] + grid[i + 1][j] + grid[i + 1][j + 1]);
        }
    }

    return result;
}
