#include "problem_486.h"

bool problem_486::test() {
    std::vector nums  { 1, 5, 2 };

    bool expected = false;

    auto result = predictTheWinner(nums);

    return result == expected;
}

bool problem_486::predictTheWinner(std::vector<int> &nums) {
    int n = nums.size();
    int first = n % 2;
    std::vector<int> dp(n);
    for (int i = 0; i < n; ++i)
        dp[i] = first == 0 ? -nums[i] : nums[i];
    for (int i = n - 1; i > 0; --i)
    {
        int sh = n - i;
        for (int j = 0; j < i; ++j)
        {
            dp[j] = i % 2 == 1 ? std::max(dp[j] + nums[j + sh], dp[j + 1] + nums[j]) : std::min(dp[j] - nums[j + sh], dp[j + 1] - nums[j]);
        }
    }

    return dp[0] >= 0;
}
