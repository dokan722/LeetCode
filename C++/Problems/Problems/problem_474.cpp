#include "problem_474.h"

bool problem_474::test() {
    std::vector<std::string> strs { "10", "0001", "111001", "1", "0" };
    int m = 5;
    int n = 3;

    int expected = 4;

    auto result = findMaxForm(strs, m, n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_474::findMaxForm(std::vector<std::string> &strs, int m, int n) {
    std::vector dp(m + 1, std::vector(n + 1, 0));

    for (auto str : strs)
    {
        int zeros = 0;
        for (auto c : str)
        {
            if (c == '0')
                zeros++;
        }
        int ones = str.size() - zeros;
        for (int i = m; i >= zeros; --i)
        {
            for (int j = n; j >= ones; --j)
            {
                dp[i][j] = std::max(dp[i][j], dp[i - zeros][j - ones] + 1);
            }
        }
    }

    int result = 0;
    for (int i = 0; i <= m; ++i)
        for (int j = 0; j <= n; ++j)
            result = std::max(result, dp[i][j]);

    return result;
}
