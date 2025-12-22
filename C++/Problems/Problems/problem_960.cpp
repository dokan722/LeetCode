#include "problem_960.h"

bool problem_960::test() {
    std::vector<std::string> strs{ "babca", "bbazb" };

    int expected = 3;

    auto result = minDeletionSize(strs);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_960::minDeletionSize(std::vector<std::string> &strs) {
    int n = strs.size();
    int m = strs[0].size();
    std::vector dp(m, 1);
    for (int i = 0; i < m; ++i)
    {
        for (int j = 0; j < i; ++j)
        {
            bool sorted = true;
            for (int k = 0; k < n; ++k)
            {
                if (strs[k][i] < strs[k][j])
                {
                    sorted = false;
                    break;
                }
            }

            if (sorted)
                dp[i] = std::max(dp[i], dp[j] + 1);

        }
    }

    int result = 0;
    for (int i = 0; i < m; ++i)
        result = std::max(result, dp[i]);

    return m - result;
}
