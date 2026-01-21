#include "problem_1653.h"

bool problem_1653::test() {
    std::string s = "aababbab";

    int expected = 2;

    auto result = minimumDeletions(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1653::minimumDeletions(std::string s) {
    int n = s.size();
    int bs = 0;
    int dp = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == 'b')
            bs++;
        else
            dp = std::min(dp + 1, bs);
    }

    return dp;
}
