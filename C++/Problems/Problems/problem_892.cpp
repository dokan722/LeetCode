#include "problem_892.h"

bool problem_892::test() {
    std::vector<std::vector<int>> grid =  {  { 1, 1, 1 },  { 1, 0, 1 },  { 1, 1, 1 } };

    int expected = 32;

    auto result = surfaceArea(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_892::surfaceArea(std::vector<std::vector<int>> &grid) {
    int result = 0;
    int n = grid.size();
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            int up = i == 0 ? grid[i][j] : std::max(0, grid[i][j] - grid[i - 1][j]);
            int down = i == n - 1 ? grid[i][j] : std::max(0, grid[i][j] - grid[i + 1][j]);
            int left = j == 0 ? grid[i][j] : std::max(0, grid[i][j] - grid[i][j - 1]);
            int right = j == n - 1 ? grid[i][j] : std::max(0, grid[i][j] - grid[i][j + 1]);
            int rest = grid[i][j] == 0 ? 0 : 2;
            result += up + down + left + right + rest;
        }
    }
    return result;
}
