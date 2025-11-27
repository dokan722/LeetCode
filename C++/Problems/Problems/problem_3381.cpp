#include "problem_3381.h"

bool problem_3381::test() {
    std::vector nums { -5, 1, 2, -3, 4 };
    int k = 2;

    int expected = 4;

    auto result = maxSubarraySum(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3381::maxSubarraySum(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector<long long> worstPrefs(k, LONG_LONG_MAX / 2);
    long long prefSum = 0;
    long long maxSum = LONG_LONG_MIN;
    worstPrefs[k - 1] = 0;
    for (int i = 0; i < n; ++i)
    {
        prefSum += nums[i];
        maxSum = std::max(maxSum, prefSum - worstPrefs[i % k]);
        worstPrefs[i % k] = std::min(worstPrefs[i % k], prefSum);
    }

    return maxSum;
}
