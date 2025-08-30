#include "problem_1155.h"

bool problem_1155::test() {
    int n = 30;
    int k = 30;
    int target = 500;

    int expected = 222616187;

    auto result = numRollsToTarget(n, k, target);

    std::cout << result << std::endl;

    return expected == result;
}

int _mod = 1000000007;

int problem_1155::numRollsToTarget(int n, int k, int target) {
    std::vector dp(n + 1, std::vector<int>(target + 1, -1));
    return NumRollsRec(n, k, target, dp);
}

int problem_1155::NumRollsRec(int n, int k, int target, std::vector<std::vector<int>> &dp) {
    if (n * k < target || n > target)
        return 0;
    if (target == n)
        return 1;
    if (n == 0)
        return 0;

    if (dp[n][target] != -1)
        return dp[n][target];

    long long result = 0;
    for (int i = 1; i <= k; ++i)
    {
        result = (result + NumRollsRec(n - 1, k, target - i, dp)) % _mod;
    }

    dp[n][target] = (int)result;
    return dp[n][target];
}
