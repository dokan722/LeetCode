#include "problem_3546.h"

bool problem_3546::test() {
    std::vector<std::vector<int>> grid { { 1, 4 }, { 2, 3 } };

    bool expected = true;

    auto result = canPartitionGrid(grid);

    return result == expected;
}

bool problem_3546::canPartitionGrid(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    long long s = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            s += grid[i][j];
    }
    if (s % 2 != 0)
        return false;
    long long req = s / 2;
    long long hor = 0;
    long long ver = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            hor += grid[i][j];
        }
        if (hor == req)
            return true;
    }
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            ver += grid[j][i];
        }
        if (ver == req)
            return true;
    }


    return false;
}
