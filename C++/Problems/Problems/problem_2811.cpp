#include "problem_2811.h"

bool problem_2811::test() {
    std::vector nums  { 2, 2, 1 };
    int m = 4;

    bool expected = true;

    auto result = canSplitArray(nums, m);

    return result == expected;
}

bool problem_2811::canSplitArray(std::vector<int> &nums, int m) {
    int n = nums.size();
    if (n < 3)
        return true;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i - 1] + nums[i] >= m)
            return true;
    }

    return false;
}
