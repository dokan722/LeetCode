#include "problem_2482.h"

bool problem_2482::test() {
    std::vector<std::vector<int>> grid {  { 0, 1, 1 },  { 1, 0, 1 }, { 0, 0, 1 } };

    std::vector<std::vector<int>> expected  {  { 0, 0, 4 },  { 0, 0, 4 },  { -2, -2, 2 } };

    auto result = onesMinusZeros(grid);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_2482::onesMinusZeros(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    std::vector rowOnes(n, 0);
    std::vector rowZeros(n, 0);
    std::vector colOnes(m, 0);
    std::vector colZeros(m, 0);
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (grid[i][j] == 0)
            {
                rowZeros[i]++;
                colZeros[j]++;
            }
            else if (grid[i][j] == 1)
            {
                rowOnes[i]++;
                colOnes[j]++;
            }
        }
    }
    std::vector result(n, std::vector<int>(m));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
            result[i][j] = rowOnes[i] + colOnes[j] - rowZeros[i] - colZeros[j];
    }

    return result;
}
