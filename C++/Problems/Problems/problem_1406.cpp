#include "problem_1406.h"

bool problem_1406::test() {
    std::vector stoneValue { 1, 2, 3, 7 };

    std::string expected = "Bob";

    auto result = stoneGameIII(stoneValue);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1406::stoneGameIII(std::vector<int> &stoneValue) {
    int n = stoneValue.size();
    std::string a = "Alice";
    std::string b = "Bob";
    std::string t = "Tie";
    std::vector<int> dp(n + 1);
    for (int i = n - 1; i >= 0; --i)
    {
        int best = INT_MIN;
        int s = 0;
        for (int k = 1; k <= 3; k++)
        {
            if (i + k > n)
                break;
            s += stoneValue[i + k - 1];
            best = std::max(best, s - dp[i + k]);
        }
        dp[i] = best;
    }
    if (dp[0] > 0)
        return a;
    if (dp[0] < 0)
        return b;
    return t;
}
