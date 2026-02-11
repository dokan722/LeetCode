#include "problem_2658.h"

bool problem_2658::test() {
    std::vector<std::vector<int>> grid  {  { 0, 2, 1, 0 },  { 4, 0, 0, 3 },  { 1, 0, 0, 4 },  { 0, 3, 2, 0 } };

    int expected = 7;

    auto result = findMaxFish(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2658::findMaxFish(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int result = 0;
    std::vector visited(n, std::vector(m, false));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            result = std::max(result, dfs(i, j, visited, grid));
    }

    return result;
}

int problem_2658::dfs(int x, int y, std::vector<std::vector<bool>> &visited, std::vector<std::vector<int>> &grid) {
    if (x < 0 || x >= visited.size() || y < 0 || y >= visited[0].size() || visited[x][y] || grid[x][y] == 0)
        return 0;
    visited[x][y] = true;
    return grid[x][y] + dfs(x - 1, y, visited, grid) + dfs(x, y - 1, visited, grid) + dfs(x + 1, y, visited, grid) + dfs(x, y + 1, visited, grid);
}
