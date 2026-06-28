#include "problem_3152.h"

bool problem_3152::test() {
    std::vector nums { 3, 4, 1, 2, 6 };
    std::vector<std::vector<int>> queries { { 0, 4 } };

    std::vector expected { false };

    auto result = isArraySpecial(nums, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<bool> problem_3152::isArraySpecial(std::vector<int> &nums, std::vector<std::vector<int>> &queries) {
    int n = nums.size();
    std::vector<int> lastSame(n);
    lastSame[0] = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] % 2 == nums[i - 1] % 2)
            lastSame[i] = i;
        else
            lastSame[i] = lastSame[i - 1];
    }

    int m = queries.size();
    std::vector result(m, false);
    for (int i = 0; i < m; ++i)
    {
        if (lastSame[queries[i][1]] <= queries[i][0])
            result[i] = true;
    }

    return result;
}
