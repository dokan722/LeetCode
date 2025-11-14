#include "problem_2536.h"

bool problem_2536::test() {
    int n = 3;
    std::vector<std::vector<int>> queries {  {1, 1, 2, 2 }, { 0, 0, 1, 1 } };

    std::vector<std::vector<int>> expected { { 1, 1, 0 }, { 1, 2, 1 }, { 0, 1, 1 } };

    auto result = rangeAddQueries(n, queries);

    print2DVector(result);

    return result == expected;
}

std::vector<std::vector<int>> problem_2536::rangeAddQueries(int n, std::vector<std::vector<int>> &queries) {
    std::vector ranges(n + 1, std::vector(n + 1, 0));
    for (auto query : queries)
    {
        ranges[query[0]][query[3] + 1]--;
        ranges[query[2] + 1][query[1]]--;
        ranges[query[0]][query[1]]++;
        ranges[query[2] + 1][query[3] + 1]++;
    }
    std::vector result(n, std::vector(n, 0));
    result[0][0] = ranges[0][0];
    for (int i = 1; i < n; ++i)
    {
        result[0][i] = result[0][i - 1] + ranges[0][i];
        result[i][0] = result[i - 1][0] + ranges[i][0];
    }

    for (int i = 1; i < n; ++i)
    {
        for (int j = 1; j < n; ++j)
        {
            result[i][j] = result[i][j - 1] + result[i - 1][j] + ranges[i][j] - result[i - 1][j - 1];
        }
    }

    return result;
}
