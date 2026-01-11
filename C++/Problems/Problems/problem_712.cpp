#include "problem_712.h"

bool problem_712::test() {
    std::string s1 = "delete";
    std::string s2 = "leet";

    int expected = 403;

    auto result = minimumDeleteSum(s1, s2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_712::minimumDeleteSum(std::string s1, std::string s2) {
    int n = s1.size();
    int m = s2.size();
    std::vector dp(n + 1, std::vector(m + 1, 0));
    for (int i = 1; i <= n; ++i)
        dp[i][0] = dp[i - 1][0] + s1[i - 1];
    for (int i = 1; i <= m; ++i)
        dp[0][i] = dp[0][i - 1] + s2[i - 1];


    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < m; ++j)
        {
            int addBoth = dp[i][j] + (s1[i] == s2[j] ? 0 : s1[i] + s2[j]);
            int addFirst = dp[i][j + 1] + s1[i];
            int addSecond = dp[i + 1][j] + s2[j];
            dp[i + 1][j + 1] = std::min(addBoth, std::min(addFirst, addSecond));
        }
    }

    return dp[n][m];
}
