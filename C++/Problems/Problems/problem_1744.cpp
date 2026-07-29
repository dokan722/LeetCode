#include "problem_1744.h"

bool problem_1744::test() {
    std::vector candiesCount { 7, 4, 5, 3, 8 };
    std::vector<std::vector<int>> queries {{ 0, 2, 2 }, { 4, 2, 4 }, { 2, 13, 1000000000 } };

    std::vector expected { true, false, true };

    auto result = canEat(candiesCount, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<bool> problem_1744::canEat(std::vector<int> &candiesCount, std::vector<std::vector<int>> &queries) {
    int n = candiesCount.size();
    std::vector<long long> pref(n + 1);
    pref[0] = 0;
    for (int i = 0; i < n; ++i)
        pref[i + 1] = pref[i] + candiesCount[i];
    int m = queries.size();
    std::vector<bool> result(m);
    for (int i = 0; i < m; ++i)
    {
        long long type = queries[i][0];
        long long day = queries[i][1] + 1;
        long long cap = queries[i][2];
        if (pref[type] < day * cap && pref[type + 1] >= day)
            result[i] = true;
        else
            result[i] = false;
    }

    return result;
}
