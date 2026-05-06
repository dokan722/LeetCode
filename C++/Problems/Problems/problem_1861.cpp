#include "problem_1861.h"

bool problem_1861::test() {
    std::vector<std::vector<char>> boxGrid { { '#', '.', '#' } };

    std::vector<std::vector<char>> expected { { '.' }, { '#' }, { '#' } };

    auto result = rotateTheBox(boxGrid);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<char>> problem_1861::rotateTheBox(std::vector<std::vector<char>> &boxGrid) {
    int n = boxGrid.size();
    int m = boxGrid[0].size();
    std::vector result(m, std::vector<char>(n));
    for (int i = 0; i < n; ++i)
    {
        int cur = m - 1;
        for (int j = m - 1; j >= 0; --j)
        {
            char cell = boxGrid[i][j];
            if (cell == '#')
            {
                result[cur][n - 1 - i] = '#';
                cur--;
            }
            else if (cell == '*')
            {
                for (int k = cur; k > j; --k)
                    result[k][n - 1 - i] = '.';
                result[j][n - 1 - i] = '*';
                cur = j - 1;
            }
        }
        for (int j = cur; j >= 0; --j)
            result[j][n - 1 - i] = '.';
    }

    return result;
}
