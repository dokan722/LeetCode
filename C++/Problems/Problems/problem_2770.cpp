#include "problem_2770.h"

bool problem_2770::test() {
    std::vector nums { 1, 3, 6, 4, 1, 2 };
    int target = 2;

    int expected = 3;

    auto result = maximumJumps(nums, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2770::maximumJumps(std::vector<int> &nums, int target) {
    int n = nums.size();
    std::vector<int> dp(n);
    dp[n - 1] = 0;
    for (int i = n - 2; i >= 0; --i)
    {
        int mx = -1;

        for (int j = i + 1; j < n; ++j)
        {
            if (std::abs(nums[i] - nums[j]) <= target && dp[j] != -1)
            {
                mx = std::max(mx, dp[j] + 1);
            }
        }
        dp[i] = mx;
    }

    return dp[0];
}
