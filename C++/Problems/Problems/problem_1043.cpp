#include "problem_1043.h"

bool problem_1043::test() {
    std::vector arr { 1, 15, 7, 9, 2, 5, 10 };
    int k = 3;

    int expected = 84;

    auto result = maxSumAfterPartitioning(arr, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1043::maxSumAfterPartitioning(std::vector<int> &arr, int k) {
    int n = arr.size();
    std::vector<int> dp(n);
    int m = 0;
    for (int i = 0; i < k; ++i)
    {
        m = std::max(m, arr[i]);
        dp[i] = (i + 1) * m;
    }
    for (int i = k; i < n; ++i)
    {
        m = arr[i];
        int curr = arr[i];
        int best = curr + dp[i - 1];
        for (int j = 1; j < k; ++j)
        {
            if (m < arr[i - j])
            {
                curr += j * (arr[i - j] - m);
                m = arr[i - j];
            }

            curr += m;
            best = std::max(best, dp[i - j - 1] + curr);
        }

        dp[i] = best;
    }

    return dp[n - 1];
}
