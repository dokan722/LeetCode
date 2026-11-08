#include "problem_1267.h"

bool problem_1267::test() {
    std::vector<std::vector<int>> grid { { 1, 0 }, { 1, 1 } };

    int expected = 3;

    auto result = countServers(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1267::countServers(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector rows(n, 0);
    std::vector cols(m, 0);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (grid[i][j] == 1)
            {
                rows[i]++;
                cols[j]++;
            }
        }
    }
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (grid[i][j] == 1 && (rows[i] > 1 || cols[j] > 1))
                result++;
        }
    }

    return result;
}
