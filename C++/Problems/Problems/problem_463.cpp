#include "problem_463.h"

bool problem_463::test() {
    std::vector<std::vector<int>> grid  { {0, 1, 0, 0},  {1, 1, 1, 0},  {0, 1, 0, 0},  {1, 1, 0, 0}};

    auto expected = 16;

    auto result = islandPerimeter(grid);

    return expected == result;
}

int problem_463::islandPerimeter(std::vector<std::vector<int>> &grid) {
    auto result = 0;
    for (int i = 0; i < grid.size(); i++)
    {
        for (int j = 0; j < grid[0].size(); j++)
            result += checkCell(i, j, grid);
    }

    return result;
}

int problem_463::checkCell(int i, int j, std::vector<std::vector<int>>& grid) {
    if (grid[i][j] == 0)
        return 0;
    int edges = 0;
    if (i == 0 || grid[i - 1][j] == 0)
        edges++;
    if (i == grid.size() - 1 || grid[i + 1][j] == 0)
        edges++;
    if (j == 0 || grid[i][j - 1] == 0)
        edges++;
    if (j == grid[0].size() - 1 || grid[i][j + 1] == 0)
        edges++;
    return edges;
}
