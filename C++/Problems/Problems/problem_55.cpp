#include "problem_55.h"

bool problem_55::test() {
    std::vector nums { 2, 3, 1, 1, 4 };

    bool expected = true;

    auto result = canJump(nums);

    return result == expected;
}

bool problem_55::canJump(std::vector<int> &nums) {
    int n = nums.size();
    int mx = 0;
    for (int i = 0; i < n; ++i)
    {
        if (mx < i)
            return false;
        mx = std::max(mx, i + nums[i]);
    }

    return true;
}
