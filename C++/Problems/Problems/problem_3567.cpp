#include "problem_3567.h"

bool problem_3567::test() {
    std::vector<std::vector<int>> grid  { { 1, 8 },{ 3, -2 } };
    int k = 2;

    std::vector<std::vector<int>> expected  { { 2 } };

    auto result = minAbsDiff(grid, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_3567::minAbsDiff(std::vector<std::vector<int>> &grid, int k) {
    int m = grid.size();
    int n = grid[0].size();
    std::vector result(m - k + 1, std::vector<int>(n - k + 1));

    for (int i = 0; i + k <= m; i++)
    {
        for (int j = 0; j + k <= n; j++)
        {
            std::vector<int> elems;
            for (int l = i; l < i + k; l++)
            {
                for (int o = j; o < j + k; o++)
                {
                    elems.push_back(grid[l][o]);
                }
            }
            int smallest = INT_MAX;
            std::sort(elems.begin(), elems.end());
            for (int t = 1; t < elems.size(); t++)
            {
                if (elems[t] == elems[t - 1])
                    continue;
                smallest = std::min(smallest, elems[t] - elems[t - 1]);
            }
            result[i][j] = smallest == INT_MAX ? 0 : smallest;
        }
    }
    return result;
}
