#include "problem_3159.h"

bool problem_3159::test() {
    std::vector nums { 1, 3, 1, 7 };
    std::vector queries { 1, 3, 2, 4 };
    int x = 1;

    std::vector expected { 0, -1, 2, -1 };

    auto result = occurrencesOfElement(nums, queries, x);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3159::occurrencesOfElement(std::vector<int> &nums, std::vector<int> &queries, int x) {
    int n = nums.size();
    std::vector<int> ids;
    for (int i = 0; i < n; i++)
    {
        if (nums[i] == x)
            ids.push_back(i);
    }

    int m = queries.size();
    int maxId = ids.size();
    if (maxId == 0)
        return std::vector(m, -1);
    std::vector<int> result(m);

    for (int i = 0; i < m; ++i)
        result[i] = queries[i] <= maxId ? ids[queries[i] - 1] : -1;

    return result;
}
