#include "problem_778.h"

#include <queue>

bool problem_778::test() {
    std::vector<std::vector<int>> grid {{0, 1, 2, 3, 4}, {24, 23, 22, 21, 5}, {12, 13, 14, 15, 16}, {11, 17, 18, 19, 20}, {10, 9, 8, 7, 6}};

    int expected = 16;

    auto result = swimInWater(grid);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_778::swimInWater(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    std::vector visited(n, std::vector(n, false));
    std::priority_queue<std::tuple<int,int,int>, std::vector<std::tuple<int,int,int>>, std::greater<>> queue;
    queue.push(std::tuple(grid[0][0], 0, 0));

    while (!queue.empty())
    {
        auto [lvl, x, y] = queue.top();
        queue.pop();
        if (visited[x][y])
            continue;
        visited[x][y] = true;
        if (x == n - 1 && x == y)
            return lvl;
        if (x > 0 && !visited[x - 1][y])
            queue.push(std::tuple(std::max(grid[x - 1][y], lvl), x - 1, y));
        if (x < n - 1 && !visited[x + 1][y])
            queue.push(std::tuple(std::max(grid[x + 1][y], lvl), x + 1, y));
        if (y > 0 && !visited[x][y - 1])
            queue.push(std::tuple(std::max(grid[x][y - 1], lvl), x, y - 1));
        if (y < n - 1 && !visited[x][y + 1])
            queue.push(std::tuple(std::max(grid[x][y + 1], lvl), x, y + 1));
    }

    return 0;
}
