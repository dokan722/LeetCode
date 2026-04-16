#include "problem_3488.h"

#include <unordered_map>

bool problem_3488::test() {
    std::vector nums { 1, 3, 1, 4, 1, 3, 2 };
    std::vector queries { 0, 3, 5 };

    std::vector expected { 2, -1, 3 };

    auto result = solveQueries(nums, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3488::solveQueries(std::vector<int> &nums, std::vector<int> &queries) {
    int n = nums.size();
    int m = queries.size();
    std::vector<int> result(m);
    std::vector dists(n, INT_MAX);
    std::unordered_map<int, std::pair<int, int>> pos;
    for (int i = 0; i < n; ++i)
    {
        if (!pos.contains(nums[i]))
            pos[nums[i]] = std::pair(i, i);
        else
        {
            auto p = pos[nums[i]];
            int back = i - p.second;
            int front = n - i + p.first;
            pos[nums[i]] = std::pair(p.first, i);
            dists[i] = std::min(back, front);
            dists[p.first] = std::min(dists[p.first], front);
            dists[p.second] = std::min(dists[p.second], back);
        }
    }

    for (int i = 0; i < m; ++i)
        result[i] = dists[queries[i]] == INT_MAX ? -1 : dists[queries[i]];

    return result;
}
