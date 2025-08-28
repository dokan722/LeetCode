#include "problem_3446.h"

#include <algorithm>

bool problem_3446::test() {
    std::vector<std::vector<int>> grid {  { 1, 7, 3 },  { 9, 8, 2 },  { 4, 5, 6 } };

    std::vector<std::vector<int>> expected {  { 8, 2, 3 },  { 9, 6, 7 },  { 4, 5, 1 } };

    auto result = sortMatrix(grid);

    return result == expected;
}

std::vector<std::vector<int>> problem_3446::sortMatrix(std::vector<std::vector<int>> &grid) {
    int n = grid.size();

    for (int i = 0; i < n; ++i)
    {
        std::vector<int> helper(i + 1);
        for (int j = 0; j <= i; ++j)
            helper[j] = grid[n - 1 - i + j][j];
        std::sort(helper.begin(), helper.end(), [](const int a, const int b) { return a > b;});
        for (int j = 0; j <= i; ++j)
            grid[n - 1 - i + j][j] = helper[j];
    }

    for (int i = 0; i < n - 1; ++i)
    {
        std::vector<int> helper(i + 1);
        for (int j = 0; j <= i; ++j)
            helper[j] = grid[j][n - 1 - i + j];
        std::sort(helper.begin(), helper.end());
        for (int j = 0; j <= i; ++j)
            grid[j][n - 1 - i + j] = helper[j];
    }

    return grid;
}
