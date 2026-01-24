#include "problem_1685.h"

#include <cmath>

bool problem_1685::test() {
    std::vector nums { 1, 4, 6, 8, 10 };

    std::vector expected { 24, 15, 13, 15, 21 };

    auto result = getSumAbsoluteDifferences(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1685::getSumAbsoluteDifferences(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result(n);
    int sum = 0;
    for (auto num : nums)
        sum += num;
    int preSum = 0;
    for (int i = 0; i < n; ++i)
    {
        int sumAfter = sum - preSum - (n - i) * nums[i];
        int sumBefore = i * nums[i] - preSum;
        result[i] = sumAfter + sumBefore;
        preSum += nums[i];
    }
    return result;
}

