#include "problem_775.h"

bool problem_775::test() {
    std::vector nums { 1, 0, 2 };

    bool expected = true;

    auto result = isIdealPermutation(nums);

    return expected == result;
}

bool problem_775::isIdealPermutation(std::vector<int> &nums) {
    int n = nums.size();
    for (int i = 0; i < n; ++i)
    {
        if (std::abs(nums[i] - i) > 1)
            return false;
    }

    return true;
}
