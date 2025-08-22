#include "problem_3195.h"

bool problem_3195::test() {
    std::vector<std::vector<int>> grid  {  { 0, 1, 0 },  { 1, 0, 1 } };

    auto expected = 6;

    auto result = minimumArea(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3195::minimumArea(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int top = 0;
    int found = false;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            if (grid[i][j] == 1)
            {
                top = i;
                found = true;
                break;
            }
        if (found)
            break;
    }
    int bot = 0;
    found = false;
    for (int i = n - 1; i >= 0; --i)
    {
        for (int j = 0; j < m; ++j)
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
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
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
    for (int i = m - 1; i >= 0; --i)
    {
        for (int j = 0; j < n; ++j)
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
