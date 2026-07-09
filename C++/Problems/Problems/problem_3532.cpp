#include "problem_3532.h"

bool problem_3532::test() {
    int n = 2;
    std::vector nums  { 1, 3 };
    int maxDiff = 1;
    std::vector<std::vector<int>> queries  { { 0, 0 }, { 0, 1 } };

    std::vector expected { true, false };

    auto result = pathExistenceQueries(n, nums, maxDiff, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<bool> problem_3532::pathExistenceQueries(int n, std::vector<int> &nums, int maxDiff,
    std::vector<std::vector<int>> &queries) {
    std::vector<int> clusts(n);
    int cur = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i - 1] + maxDiff < nums[i])
            cur++;
        clusts[i] = cur;
    }
    int m = queries.size();
    std::vector<bool> result(m);
    for (int i = 0; i < m; ++i)
    {
        auto& q = queries[i];
        result[i] = clusts[q[0]] == clusts[q[1]];
    }

    return result;
}
