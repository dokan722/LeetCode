#include "problem_1340.h"

bool problem_1340::test() {
    std::vector arr { 6, 4, 14, 6, 8, 13, 9, 7, 10, 6, 12 };
    int d = 2;

    int expected = 4;

    auto result = maxJumps(arr, d);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1340::maxJumps(std::vector<int> &arr, int d) {
    int n = arr.size();
    std::vector dp(n , 0);
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        dfs(arr, d, i, n, dp);
        result = std::max(result, dp[i]);
    }

    return result;
}

void problem_1340::dfs(std::vector<int> &arr, int d, int id, int n, std::vector<int> &dp) {
    if (dp[id] != 0)
        return;
    dp[id] = 1;
    for (int i = id - 1; i >= 0 && id - i <= d && arr[i] < arr[id]; --i)
    {
        dfs(arr, d, i, n, dp);
        dp[id] = std::max(dp[id], dp[i] + 1);
    }
    for (int i = id + 1; i < n && i - id <= d && arr[i] < arr[id]; ++i)
    {
        dfs(arr, d, i, n, dp);
        dp[id] = std::max(dp[id], dp[i] + 1);
    }
}
