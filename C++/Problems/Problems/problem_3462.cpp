#include "problem_3462.h"

#include <queue>
#include <bits/locale_facets_nonio.h>

bool problem_3462::test() {
    std::vector<std::vector<int>> grid { { 5, 3, 7 }, { 8, 2, 6 } };
    std::vector limits { 2, 2 };
    int k = 3;

    int expected = 21;

    auto result = maxSum(grid, limits, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3462::maxSum(std::vector<std::vector<int>> &grid, std::vector<int> &limits, int k) {
    int n = grid.size();
    int m = grid[0].size();
    std::priority_queue<std::pair<int, int>> que;
    for (int i = 0; i < n; ++i)
        for (int j = 0; j < m; ++j)
            que.push(std::pair(grid[i][j], i));
    std::vector filled(n, 0);
    int taken = 0;
    long long result = 0;
    while (!que.empty() && taken < k)
    {
        auto elem = que.top();
        que.pop();
        if (filled[elem.second] < limits[elem.second])
        {
            result += elem.first;
            filled[elem.second]++;
            taken++;
        }
    }

    return result;
}
