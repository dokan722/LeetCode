#include "problem_3487.h"

#include <numeric>
#include <unordered_set>

bool problem_3487::test() {
    std::vector nums { 1, 2, -1, -2, 1, 0, -1 };

    auto expected = 3;

    auto result = maxSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3487::maxSum(std::vector<int> &nums) {
    std::pmr::unordered_set<int> valuesSet;
    auto max = nums[0];
    for (auto num : nums)
    {
        if (num > 0)
            valuesSet.insert(num);
        if (max < num)
            max = num;

    }

    if (max < 0)
        return max;

    return std::accumulate(valuesSet.begin(), valuesSet.end(), 0);
}
