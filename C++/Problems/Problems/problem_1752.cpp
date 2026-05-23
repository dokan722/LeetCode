#include "problem_1752.h"

bool problem_1752::test() {
    std::vector nums { 3, 4, 5, 1, 2 };

    bool expected = true;

    auto result = check(nums);

    return result == expected;
}

bool problem_1752::check(std::vector<int> &nums) {
    int n = nums.size();
    int miss = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i - 1] > nums[i])
            miss++;
        if (miss >= 2)
            return false;
    }

    return miss == 0 || nums[n - 1] <= nums[0];
}
