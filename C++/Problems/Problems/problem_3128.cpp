#include "problem_3128.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_3128::test() {
    std::vector<std::vector<int>> grid  {  { 0, 1, 0 },  { 0, 1, 1 },  { 0, 1, 0 } };

    auto expected = 2;

    auto result = numberOfRightTriangles(grid);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_3128::numberOfRightTriangles(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector<int> rows(n);
    std::vector<int> cols(m);

    for (int i = 0; i < n; ++i)
    {
        for (int j = m - 1; j >= 0; --j)
        {
            if (grid[i][j] == 1)
            {
                rows[i]++;
                cols[j]++;
            }
        }
    }

    long long result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (grid[i][j] != 0 && rows[i] > 1 && cols[j] > 1)
            {
                result += (rows[i] - 1) * (cols[j] - 1);
            }
        }
    }

    return result;
}
