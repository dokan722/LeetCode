#include "problem_3637.h"

bool problem_3637::test() {
    std::vector nums { 1, 3, 5, 4, 2, 6 };

    bool expected = true;

    auto result = isTrionic(nums);

    return result == expected;
}

bool problem_3637::isTrionic(std::vector<int> &nums) {
    int n = nums.size();
    if (nums[0] >= nums[1])
    {
        return false;
    }
    int count = 1;
    for (int i = 2; i < n; i++)
    {
        if (nums[i - 1] == nums[i])
            return false;
        if ((nums[i - 2] - nums[i - 1]) * (nums[i - 1] - nums[i]) < 0)
        {
            count++;
        }
    }
    return count == 3;
}

