#include "problem_840.h"

bool problem_840::test() {
    std::vector<std::vector<int>> grid { { 4, 3, 8, 4 }, { 9, 5, 1, 9 }, { 2, 7, 6, 2 } };

    int expected = 1;

    auto result = numMagicSquaresInside(grid);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_840::numMagicSquaresInside(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int result = 0;

    for (int i = 0; i < n - 2; ++i)
    {
        for (int j = 0; j < m - 2; ++j)
        {
            std::vector present(9, false);
            bool invalid = false;
            for (int l = 0; l < 9; ++l)
            {
                int val = grid[i + l / 3][j + l % 3];
                if (val < 1 || val > 9)
                {
                    invalid = true;
                    break;
                }
                present[val - 1] = true;
            }
            for (int l = 0; l < 9; ++l)
                if (!present[l])
                    invalid = true;
            if (!invalid &&
                grid[i][j] + grid[i][j + 1] + grid[i][j + 2] == 15 &&
                grid[i + 1][j] + grid[i + 1][j + 1] + grid[i + 1][j + 2] == 15 &&
                grid[i + 2][j] + grid[i + 2][j + 1] + grid[i + 2][j + 2] == 15 &&
                grid[i][j] + grid[i + 1][j + 1] + grid[i + 2][j + 2] == 15 &&
                grid[i][j] + grid[i + 1][j] + grid[i + 2][j] == 15 &&
                grid[i][j + 1] + grid[i + 1][j + 1] + grid[i + 2][j + 1] == 15 &&
                grid[i][j + 2] + grid[i + 1][j + 2] + grid[i + 2][j + 2] == 15 &&
                grid[i][j + 2] + grid[i + 1][j + 1] + grid[i + 2][j] == 15)
                result++;
        }
    }

    return result;
}
