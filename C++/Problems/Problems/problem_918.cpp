#include "problem_918.h"

bool problem_918::test() {
    std::vector nums { 5, -3, 5 };

    auto expected = 10;

    auto result = maxSubarraySumCircular(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_918::maxSubarraySumCircular(std::vector<int> &nums) {
    auto runningMax = nums[0];
    auto runningMin = nums[0];
    auto maxSum = nums[0];
    auto minSum = nums[0];
    auto sum = nums[0];
    for (int i = 1; i < nums.size(); i++)
    {
        runningMax = std::max(nums[i], runningMax + nums[i]);
        runningMin = std::min(nums[i], runningMin + nums[i]);

        maxSum = std::max(maxSum, runningMax);
        minSum = std::min(minSum, runningMin);

        sum += nums[i];
    }

    if (sum == minSum)
        return maxSum;

    return std::max(maxSum, sum - minSum);
}
