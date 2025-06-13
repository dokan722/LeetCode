#include "problem_3423.h"
#include <cmath>

bool problem_3423::test() {
    std::vector<int> nums =  { 1, 2, 4 };


    auto expected = 3;

    auto result = maxAdjacentDistance(nums);

    return expected == result;
}

int problem_3423::maxAdjacentDistance(std::vector<int> &nums) {
    auto maxDiff = std::abs(nums[nums.size() - 1] - nums[0]);

    for (int i = 0; i < nums.size() - 1; i++)
    {
        auto diff = std::abs(nums[i] - nums[i + 1]);
        if (diff > maxDiff)
            maxDiff = diff;
    }

    return maxDiff;
}
