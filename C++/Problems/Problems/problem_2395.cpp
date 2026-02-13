#include "problem_2395.h"

#include <unordered_set>

bool problem_2395::test() {
    std::vector nums { 1, 2, 3, 4, 5 };

    bool expected = false;

    auto result = findSubarrays(nums);

    return result == expected;
}

bool problem_2395::findSubarrays(std::vector<int> &nums) {
    int n = nums.size();
    std::unordered_set<int> sums;
    for (int i = 1; i < n; ++i)
    {
        int s = nums[i - 1] + nums[i];
        if (sums.contains(s))
            return true;
        sums.insert(s);
    }

    return false;
}
