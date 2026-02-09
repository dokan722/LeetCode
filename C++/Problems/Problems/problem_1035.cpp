#include "problem_1035.h"

bool problem_1035::test() {
    std::vector nums1 { 2, 5, 1, 2, 5 };
    std::vector nums2 { 10, 5, 2, 1, 5, 2 };

    int expected = 3;

    auto result = maxUncrossedLines(nums1, nums2);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1035::maxUncrossedLines(std::vector<int> &nums1, std::vector<int> &nums2) {
    int n = nums1.size();
    int m = nums2.size();
    std::vector dp(n + 1, std::vector<int>(m + 1, 0));
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int takeBoth = dp[i][j] + (nums1[i] == nums2[j] ? 1 : 0);
            int takeFirst = dp[i][j + 1];
            int takeSecond = dp[i + 1][j];
            dp[i + 1][j + 1] = std::max(takeBoth, std::max(takeFirst, takeSecond));
        }
    }

    return dp[n][m];
}
