#include "problem_1458.h"

bool problem_1458::test() {
    std::vector nums1 { 2, 1, -2, 5 };
    std::vector nums2 { 3, 0, -6 };

    int expected = 18;

    auto result = maxDotProduct(nums1, nums2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1458::maxDotProduct(std::vector<int> &nums1, std::vector<int> &nums2) {
    int n = nums1.size();
    int m = nums2.size();
    std::vector<std::vector<int>> dp(n, std::vector<int>(m, 0));
    dp[0][0] = nums1[0] * nums2[0];
    int result = dp[0][0];
    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int takeBoth = nums1[i] * nums2[j] + (i > 0 && j > 0 ? dp[i - 1][j - 1] : 0);
            int takeBothAndSkip = nums1[i] * nums2[j];
            int skipFirst = i > 0 ? dp[i - 1][j] : INT_MIN;
            int skipSecond = j > 0 ? dp[i][j - 1] : INT_MIN;
            dp[i][j] = std::max(takeBoth, std::max(takeBothAndSkip, std::max(skipFirst, skipSecond)));
        }
    }

    return dp[n - 1][m - 1];
}
