#include "problem_1800.h"

bool problem_1800::test() {
    std::vector nums { 12, 17, 15, 13, 10, 11, 12 };

    int expected = 33;

    auto result = maxAscendingSum(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1800::maxAscendingSum(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    int runningSum = nums[0];
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] <= nums[i - 1])
        {
            result = std::max(result, runningSum);
            runningSum = nums[i];
        }
        else
            runningSum += nums[i];
    }
    result = std::max(result, runningSum);

    return result;
}
