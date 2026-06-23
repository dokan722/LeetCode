#include "problem_1020.h"

#include <queue>

bool problem_1020::test() {
    std::vector<std::vector<int>> grid {  { 0, 0, 0, 0 },  { 1, 0, 1, 0 },  { 0, 1, 1, 0 },  { 0, 0, 0, 0 } };

    int expected = 3;

    auto result = numEnclaves(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1020::numEnclaves(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::queue<std::pair<int, int>> que;
    std::vector<std::vector<int>> dirs  {  { -1, 0 },  { 0, -1 }, { 1, 0 },  { 0, 1 } };
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (grid[i][j] == 0)
                continue;
            grid[i][j] = 0;
            que.push(std::pair(i, j));
            int enc = 1;
            bool exit = false;
            while (!que.empty())
            {
                auto p = que.front();
                que.pop();
                for (auto& d : dirs)
                {
                    int x = p.first + d[0];
                    int y = p.second + d[1];
                    if (x >= 0 && x < n && y >= 0 && y < m)
                    {
                        if (grid[x][y] == 1)
                        {
                            grid[x][y] = 0;
                            enc++;
                            que.push(std::pair(x, y));
                        }
                    }
                    else
                        exit = true;
                }
            }
            if (!exit)
                result += enc;
        }
    }

    return result;
}
