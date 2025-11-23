#include "problem_2162.h"

bool problem_2162::test() {
    std::vector nums { 3, 6, 5, 1, 8 };

    int expected = 18;

    auto result = maxSumDivThree(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2162::maxSumDivThree(std::vector<int> &nums) {
    int n = nums.size();

    std::vector dp { 0, INT_MIN, INT_MIN };

    for (int i = 0; i < n; i++)
    {
        std::vector<int> curr(3);
        for (int j = 0; j < 3; ++j)
            curr[j] = std::max(dp[j], dp[(j - (nums[i] % 3) + 3) % 3] + nums[i]);
        dp = curr;
    }

    return dp[0];
}
