#include "problem_3197.h"

bool problem_3197::test() {
    std::vector<std::vector<int>> grid { { 1, 0, 1 }, { 1, 1, 1 } };

    auto expected = 5;

    auto result = minimumSum(grid);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3197::minimumSum(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int result = INT_MAX;
    for (int i = 0; i < n - 1; ++i)
    {
        for (int j = 0; j < m - 1; ++j)
        {
            result = std::min(result, minimumArea(grid, 0, i, 0, j) + minimumArea(grid, 0, i, j + 1, m - 1) + minimumArea(grid, i + 1, n - 1, 0, m - 1));
            result = std::min(result, minimumArea(grid, 0, i, j + 1, m - 1) + minimumArea(grid, i + 1, n - 1, j + 1, m - 1) + minimumArea(grid, 0, n - 1, 0, j));
            result = std::min(result, minimumArea(grid, i + 1, n - 1, j + 1, m - 1) + minimumArea(grid, i + 1, n - 1, 0, j) + minimumArea(grid, 0, i, 0, m - 1));
            result = std::min(result, minimumArea(grid, i + 1, n - 1, 0, j) + minimumArea(grid, 0, i, 0, j) + minimumArea(grid, 0, n - 1, j + 1, m - 1));
        }
    }

    for (int i = 0; i < n - 2; ++i)
    {
        for (int j = i + 1; j < n - 1; ++j)
        {
            result = std::min(result, minimumArea(grid, 0, i, 0, m - 1) + minimumArea(grid, i + 1, j, 0, m - 1) + minimumArea(grid, j + 1, n - 1, 0, m - 1));
        }
    }

    for (int i = 0; i < m - 2; ++i)
    {
        for (int j = i + 1; j < m - 1; ++j)
        {
            result = std::min(result, minimumArea(grid, 0, n - 1, 0, i) + minimumArea(grid, 0, n - 1, i + 1, j) + minimumArea(grid, 0, n - 1, j + 1, m - 1));
        }
    }


    return result;
}

int problem_3197::minimumArea(std::vector<std::vector<int>> &grid, int topB, int botB, int leftB, int rightB) {
    int top = 0;
    int found = false;
    for (int i = topB; i <= botB; ++i)
    {
        for (int j = leftB; j <= rightB; ++j)
            if (grid[i][j] == 1)
            {
                top = i;
                found = true;
                break;
            }
        if (found)
            break;
    }
    if (!found)
        return INT_MAX / 3;
    int bot = 0;
    found = false;
    for (int i = botB; i >= topB; --i)
    {
        for (int j = leftB; j <= rightB; ++j)
            if (grid[i][j] == 1)
            {
                bot = i;
                found = true;
                break;
            }
        if (found)
            break;
    }
    int left = 0;
    found = false;
    for (int i = leftB; i <= rightB; ++i)
    {
        for (int j = topB; j <= botB; ++j)
            if (grid[j][i] == 1)
            {
                left = i;
                found = true;
                break;
            }
        if (found)
            break;
    }
    int right = 0;
    found = false;
    for (int i = rightB; i >= leftB; --i)
    {
        for (int j = topB; j <= botB; ++j)
            if (grid[j][i] == 1)
            {
                right = i;
                found = true;
                break;
            }
        if (found)
            break;
    }

    return (right - left + 1) * (bot - top + 1);
}
