#include "problem_407.h"

#include <queue>

bool problem_407::test() {
    std::vector<std::vector<int>> heightMap { {1, 4, 3, 1, 3, 2}, {3, 2, 1, 3, 2, 4}, {2, 3, 3, 2, 3, 1}};

    int expected = 4;

    auto result = trapRainWater(heightMap);

    std::cout << result << std::endl;

    return expected == result;
}

struct Cell {
    int height;
    int x;
    int y;
    Cell(int x, int y, int height) : x(x), y(y), height(height) {}
    bool operator<(const Cell& other) const {
        return height >= other.height;
    }
};

int problem_407::trapRainWater(std::vector<std::vector<int>> &heightMap) {
    int n = heightMap.size();
    int m = heightMap[0].size();
    std::vector visited(n, std::vector<bool>(m, false));
    std::priority_queue<Cell> boundry;
    for (int i = 0; i < n; i++)
    {
        boundry.push(Cell(i, 0, heightMap[i][0]));
        visited[i][0] = true;
        boundry.push(Cell(i, m - 1, heightMap[i][m - 1]));
        visited[i][m - 1] = true;
    }
    for (int i = 1; i < m - 1; i++)
    {
        boundry.push(Cell(0, i, heightMap[0][i]));
        visited[0][i] = true;
        boundry.push(Cell(n - 1, i, heightMap[n - 1][i]));
        visited[n - 1][i] = true;
    }

    int result = 0;
    while (!boundry.empty())
    {
        auto cell = boundry.top();
        boundry.pop();
        if (cell.x > 0 && !visited[cell.x - 1][cell.y])
        {
            int newWater = std::max(0, cell.height - heightMap[cell.x - 1][cell.y]);
            result += newWater;
            boundry.push(Cell(cell.x - 1, cell.y, heightMap[cell.x - 1][cell.y] + newWater));
            visited[cell.x - 1][cell.y] = true;
        }
        if (cell.x < n - 1 && !visited[cell.x + 1][cell.y])
        {
            int newWater = std::max(0, cell.height - heightMap[cell.x + 1][cell.y]);
            result += newWater;
            boundry.push(Cell(cell.x + 1, cell.y, heightMap[cell.x + 1][cell.y] + newWater));
            visited[cell.x + 1][cell.y] = true;
        }
        if (cell.y > 0 && !visited[cell.x][cell.y - 1])
        {
            int newWater = std::max(0, cell.height - heightMap[cell.x][cell.y - 1]);
            result += newWater;
            boundry.push(Cell(cell.x, cell.y - 1, heightMap[cell.x][cell.y - 1] + newWater));
            visited[cell.x][cell.y - 1] = true;
        }
        if (cell.y < m - 1 && !visited[cell.x][cell.y + 1])
        {
            int newWater = std::max(0, cell.height - heightMap[cell.x][cell.y + 1]);
            result += newWater;
            boundry.push(Cell(cell.x, cell.y + 1, heightMap[cell.x][cell.y + 1] + newWater));
            visited[cell.x][cell.y + 1] = true;
        }
    }

    return result;
}
