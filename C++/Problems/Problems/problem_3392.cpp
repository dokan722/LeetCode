#include "problem_3392.h"

bool problem_3392::test() {
    std::vector nums { 1, 2, 1, 4, 1 };

    auto expected = 1;

    auto result = countSubarrays(nums);


    return result == expected;
}

int problem_3392::countSubarrays(std::vector<int> &nums) {
    auto result = 0;
    for (int i = 1; i < nums.size() - 1; ++i)
    {
        if (2 * (nums[i - 1] + nums[i + 1]) == nums[i])
            result++;
    }

    return result;
}
