#include "problem_740.h"

bool problem_740::test() {
    std::vector nums { 3, 4, 2 };

    int expected = 6;

    auto result = deleteAndEarn(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_740::deleteAndEarn(std::vector<int> &nums) {
    std::vector counts(10001, 0);
    int mx = 0;
    for (auto num : nums)
    {
        counts[num]++;
        mx = std::max(mx, num);
    }
    std::vector<int> dp(mx + 1);
    dp[0] = 0;
    dp[1] = counts[1];
    for (int i = 2; i <= mx; ++i)
    {
        dp[i] = std::max(dp[i - 1], counts[i] * i + dp[i - 2]);
    }
    return dp[mx];
}
