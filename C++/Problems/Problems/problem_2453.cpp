#include "problem_2453.h"

#include <unordered_map>

bool problem_2453::test() {
    std::vector nums  { 3, 7, 8, 1, 1, 5 };
    int space = 2;

    int expected = 1;

    auto result = destroyTargets(nums, space);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2453::destroyTargets(std::vector<int> &nums, int space) {
    int maxTargets = 0;
    int result = 0;
    std::unordered_map<int, std::pair<int, int>> counts;
    for (int num : nums)
    {
        int rem = num % space;
        if (counts.contains(rem))
        {
            auto cur = counts[rem];
            counts[rem] = std::pair(std::min(cur.first, num), cur.second + 1);
        }
        else
        {
            counts[rem] = std::pair(num, 1);
        }
        auto cand = counts[rem];
        if (cand.second > maxTargets || (cand.second == maxTargets && result > cand.first))
        {
            maxTargets = cand.second;
            result = cand.first;
        }
    }

    return result;
}
