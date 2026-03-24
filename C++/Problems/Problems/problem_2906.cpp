#include "problem_2906.h"

bool problem_2906::test() {
    std::vector<std::vector<int>> grid { { 1, 2 }, { 3, 4 } };

    std::vector<std::vector<int>> expected { { 24, 12 }, { 8, 6 } };

    auto result = constructProductMatrix(grid);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_2906::constructProductMatrix(std::vector<std::vector<int>> &grid) {
    int n = grid.size();
    int m = grid[0].size();
    int l = n * m;
    int mod = 12345;
    std::vector<int> prefs(l);
    std::vector<int> sufs(l);
    prefs[0] = grid[0][0] % mod;
    sufs[l - 1] = grid[n - 1][m - 1] % mod;
    for (int i = 1; i < l; ++i)
    {
        prefs[i] = (grid[i / m][i % m] % mod) * (prefs[i - 1] % mod) % mod;
        sufs[l - i - 1] = (grid[n - 1 - (i / m)][m - 1 - (i % m)] % mod) * (sufs[l - i] % mod) % mod;
    }
    std::vector result(n, std::vector<int>(m));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            if (i == 0 && j == 0)
            {
                result[i][j] = sufs[1];
                continue;
            }
            else if (i == n - 1 && j == m - 1)
            {
                result[i][j] = prefs[l - 2];
                continue;
            }
            result[i][j] = prefs[i * m + j - 1] * sufs[i * m + j + 1] % mod;
        }
    }
    return result;
}
