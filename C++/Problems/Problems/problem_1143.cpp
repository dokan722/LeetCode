#include "problem_1143.h"

bool problem_1143::test() {
    std::string text1 = "abcde";
    std::string text2 = "ace";

    int expected = 3;

    auto result = longestCommonSubsequence(text1, text2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1143::longestCommonSubsequence(std::string text1, std::string text2) {
    int n = text1.size();
    int m = text2.size();
    std::vector dp(n + 1, std::vector(m + 1, 0));
    for (int i = 1; i <= n; ++i)
    {
        for (int j = 1; j <= m; ++j)
        {
            dp[i][j] = std::max(dp[i - 1][j - 1] + (text1[i - 1] == text2[j - 1] ? 1 : 0), std::max(dp[i - 1][j], dp[i][j - 1]));
        }
    }

    return dp[n][m];
}
