#include "problem_3286.h"

bool problem_3286::test() {
    std::vector<std::vector<int>> grid  {  { 0, 1, 0, 0, 0 },  { 0, 1, 0, 1, 0 },  { 0, 0, 0, 1, 0 } };
    int health = 1;

    bool expected = true;

    auto result = findSafeWalk(grid, health);

    return result == expected;
}

bool problem_3286::findSafeWalk(std::vector<std::vector<int>> &grid, int health) {
    if (grid[0][0] == 1)
        health--;
    std::vector<std::vector<int>> dirs{  { 1, 0 },  { 0, 1 }, { -1, 0 }, { 0, -1 } };
    int n = grid.size();
    int m = grid[0].size();
    std::vector visited(n, std::vector(m, false));
    std::queue<std::pair<int, int>> curq;
    std::queue<std::pair<int, int>> nextq;
    curq.push(std::pair(0, 0));
    visited[0][0] = true;
    while (health > 0 && (curq.size() > 0 || nextq.size() > 0))
    {
        if (curq.size() == 0)
        {
            health--;
            curq = nextq;
            nextq = std::queue<std::pair<int, int>>();
        }
        else
        {
            auto next = curq.front();
            curq.pop();
            if (next.first == n - 1 && next.second == m - 1)
                return true;
            for (auto dir : dirs)
            {
                int x = next.first + dir[0];
                int y = next.second + dir[1];
                if (x >= 0 && x < n && y >= 0 && y < m && !visited[x][y])
                {
                    visited[x][y] = true;
                    if (grid[x][y] == 0)
                        curq.push(std::pair(x, y));
                    else
                        nextq.push(std::pair(x, y));
                }
            }
        }
    }

    return false;
}
