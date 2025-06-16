#include "problem_417.h"

#include <algorithm>

bool problem_417::test() {
   std::vector<std::vector<int>> h = {  {1,2,2,3,5},  {3, 2, 3, 4, 4},  {2, 4, 5, 3, 1},  {6, 7, 1, 4, 5},  {5, 1, 1, 2, 4} };

    std::vector<std::vector<int>> expected = { { 0, 4 }, { 1, 3 }, { 1, 4 }, { 2, 2 }, { 3, 0 }, { 3, 1 }, { 4, 0 } };

    auto result = pacificAtlantic(h);

    if (result.size() != expected.size())
        return false;

    std::sort(result.begin(), result.end());
    std::sort(expected.begin(), expected.end());

    return result == expected;
}

std::vector<std::vector<int>> problem_417::pacificAtlantic(std::vector<std::vector<int>> &heights) {
    auto m = heights.size();
    auto n = heights[0].size();
    std::vector pacificCoverage(m, std::vector<bool>(n, false));
    std::vector atlanticCoverage(m, std::vector<bool>(n, false));
    std::vector<std::vector<int>> result;

    for (int i = 0; i < m; ++i)
        dfsCover(i, 0, heights, pacificCoverage);
    for (int i = 0; i < n; ++i)
        dfsCover(0, i, heights, pacificCoverage);
    for (int i = 0; i < m; ++i)
        dfsCover(i, n - 1, heights, atlanticCoverage);
    for (int i = 0; i < n; ++i)
        dfsCover(m - 1, i, heights, atlanticCoverage);

    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (pacificCoverage[i][j] && atlanticCoverage[i][j])
                result.push_back(std::vector({ i, j }));
        }
    }

    return result;
}

void problem_417::dfsCover(int i, int j, std::vector<std::vector<int>> &heights,std::vector<std::vector<bool>> &coverage) {
    if (coverage[i][j])
        return;
    coverage[i][j] = true;

    if (i - 1 >= 0 && heights[i][j] <= heights[i - 1][j])
        dfsCover(i - 1, j, heights, coverage);

    if (j - 1 >= 0 && heights[i][j] <= heights[i][j - 1])
        dfsCover(i, j - 1, heights, coverage);

    if (i + 1 < coverage.size() && heights[i][j] <= heights[i + 1][j])
        dfsCover(i + 1, j, heights, coverage);

    if (j + 1 < coverage[0].size() && heights[i][j] <= heights[i][j + 1])
        dfsCover(i, j + 1, heights, coverage);
}
