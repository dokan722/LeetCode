#include "problem_3654.h"

bool problem_3654::test() {
    std::vector nums { 1, 1, 1 };
    int k = 2;

    int expected = 1;

    auto result = minArraySum(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3654::minArraySum(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector dp(k, LONG_LONG_MAX);
    long long s = 0;
    dp[0] = 0;
    for (int i = 0; i < n; ++i)
    {
        s += nums[i];
        s = std::min(s, dp[s % k]);
        dp[s % k] = s;
    }

    return s;
}
