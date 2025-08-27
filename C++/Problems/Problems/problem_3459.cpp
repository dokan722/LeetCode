#include "problem_3459.h"

#include <unordered_map>


bool problem_3459::test() {
    std::vector<std::vector<int>> grid {{2, 2, 2, 2, 2}, {2, 0, 2, 2, 0}, {2, 0, 1, 1, 0}, {1, 0, 2, 2, 2}, {2, 0, 0, 2, 2}};

    auto expected = 4;

    auto result = lenOfVDiagonal(grid);

    std::cout << result << std::endl;

    return expected == result;
}

std::unordered_map<int, std::pair<int, int>> _turns =
{
    {11, {1, -1} },
    {9, {-1, -1} },
    {-11, {-1, 1} },
    {-9, {1, 1} },
};

int problem_3459::lenOfVDiagonal(std::vector<std::vector<int>> &grid) {
    auto result = 0;
    int n = grid.size();
    int m = grid[0].size();
    for (auto dir : _turns)
    {
        auto key = dir.second;
        std::vector dpWithTurn(n, std::vector(m, -1));
        std::vector dpWithoutTurn(n, std::vector(m, -1));

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (grid[i][j] == 1)
                    result = std::max(result, 1 + dfs(grid, dpWithTurn, dpWithoutTurn, n, m, i + key.first, j + key.second, key.first, key.second, 0, true));
            }
        }
    }

    return result;
}


int problem_3459::dfs(std::vector<std::vector<int>> &grid, std::vector<std::vector<int>> &dpWithTurn,
                      std::vector<std::vector<int>> &dpNoTurn, int n, int m, int x, int y, int ver, int hor, int prev, bool haveMove) {
    if (x < 0 || x >= n || y < 0 || y >= m || grid[x][y] == 1 || prev == grid[x][y])
        return 0;
    if (haveMove && dpWithTurn[x][y] != -1)
        return dpWithTurn[x][y];
    if (!haveMove && dpNoTurn[x][y] != -1)
        return dpNoTurn[x][y];

    auto notTurn = 1 + dfs(grid, dpWithTurn, dpNoTurn, n, m, x + ver, y + hor, ver, hor, grid[x][y], haveMove);
    if (!haveMove)
    {
        dpNoTurn[x][y] = notTurn;
        return dpNoTurn[x][y];
    }

    auto pair = _turns[10 * ver + hor];
    ver = pair.first;
    hor = pair.second;
    auto turn = 1 + dfs(grid, dpWithTurn, dpNoTurn, n, m, x + ver, y + hor, ver, hor, grid[x][y], false);
    dpWithTurn[x][y] = turn;

    return std::max(notTurn, turn);
}
