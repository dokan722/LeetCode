#include "problem_1139.h"

bool problem_1139::test() {
    std::vector<std::vector<int>> grid { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };

    int expected = 9;

    int result = largest1BorderedSquare(grid);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1139::largest1BorderedSquare(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector horizontal(n, std::vector(m, 0));
    std::vector vertical(n, std::vector(m, 0));
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (j == 0)
                horizontal[i][j] = grid[i][j];
            else
                horizontal[i][j] = grid[i][j] == 1 ? horizontal[i][j - 1] + 1 : 0;
            if (i == 0)
                vertical[i][j] = grid[i][j];
            else
                vertical[i][j] = grid[i][j] == 1 ? vertical[i - 1][j] + 1 : 0;
        }
    }

    int result = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            int maxSide = std::min(vertical[i][j], horizontal[i][j]);
            if (maxSide > result)
            {
                for (int k = maxSide; k > result; k--)
                {
                    if (vertical[i][j - k + 1] >= k && horizontal[i - k + 1][j] >= k)
                    {
                        result = k;
                        break;
                    }
                }
            }
        }
    }

    return result * result;
}
