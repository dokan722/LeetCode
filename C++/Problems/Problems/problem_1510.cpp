#include "problem_1510.h"

bool problem_1510::test() {
    int n = 4;

    bool expected = true;

    auto result = winnerSquareGame(n);

    return expected == result;
}

bool problem_1510::winnerSquareGame(int n) {
    std::vector dp(n + 1, -1);
    return canWin(dp, n);
}

bool problem_1510::canWin(std::vector<int> &dp, int n) {
    if (n <= 0)
        return false;
    if (dp[n] != -1)
        return dp[n] == 1;
    double limit = std::sqrt(n + 1);
    int res = 0;
    for (int i = 1; i < limit; ++i)
    {
        if (!canWin(dp, n - i * i))
        {
            res = 1;
            break;
        }
    }
    dp[n] = res;
    return res == 1;
}
