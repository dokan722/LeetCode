#include "problem_416.h"

bool problem_416::test() {
    std::vector nums { 1, 5, 11, 5 };

    bool expected = true;

    auto result = canPartition(nums);

    return expected == result;
}

bool problem_416::canPartition(std::vector<int> &nums) {
    int s = 0;
    for (auto num : nums)
        s += num;
    if (s % 2 == 1)
        return false;
    int req = s / 2;
    std::vector dp(req + 1, false );
    dp[0] = true;
    for (auto num : nums)
    {
        for (int i = req; i - num >= 0; --i)
        {
            dp[i] = dp[i] || dp[i - num];
        }
        if (dp[req])
            return true;
    }

    return false;
}
