#include "problem_1695.h"

#include <unordered_map>

bool problem_1695::test() {
    std::vector nums { 5, 2, 1, 2, 5, 2, 1, 2, 5 };

    auto expected = 8;

    auto result = maximumUniqueSubarray(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1695::maximumUniqueSubarray(std::vector<int> &nums) {
    int left = 0, right = 0;
    auto result = INT_MIN;
    auto runningSum = 0;
    std::unordered_map<int, int> indices;

    while (right < nums.size())
    {
        if (indices.contains(nums[right]))
        {
            while (left < indices[nums[right]] + 1)
            {
                runningSum -= nums[left];
                left++;
            }

        }
        indices[nums[right]] = right;
        runningSum += nums[right];
        right++;
        if (runningSum > result)
            result = runningSum;

    }

    return result;
}
