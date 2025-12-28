#include "problem_1351.h"

bool problem_1351::test() {
    std::vector<std::vector<int>> grid {{4, 3, 2, -1}, {3, 2, 1, -1}, {1, 1, -1, -2}, {-1, -1, -2, -3}};

    int expected = 8;

    auto result = countNegatives(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1351::countNegatives(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int i = n - 1;
    int result = 0;
    for (int j = 0; j < m; ++j)
    {
        if (grid[i][j] < 0)
        {
            result += j;
            j--;
            i--;
            if (i < 0)
                break;
        }
    }

    result = n * m - (result + (i + 1) * m);
    return result;
}
