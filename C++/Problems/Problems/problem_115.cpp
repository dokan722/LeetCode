#include "problem_115.h"

bool problem_115::test() {
    std::string s = "rabbbit";
    std::string t = "rabbit";

    int expected = 3;

    auto result = numDistinct(s, t);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_115::numDistinct(std::string s, std::string t) {
    int n = s.size();
    int m = t.size();
    if (n < m)
        return 0;
    std::vector<unsigned long long> dp(m, 0);
    for (auto c : s)
    {
        for (int i = m - 1; i > 0; --i)
        {
            if (t[i] == c)
                dp[i] += dp[i - 1];
        }
        if (c == t[0])
            dp[0]++;
    }

    return dp[m - 1];
}
