#include "problem_1563.h"

bool problem_1563::test() {
    std::vector stoneValue { 6, 2, 3, 4, 5, 5 };

    int expected = 18;

    auto result = stoneGameV(stoneValue);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1563::stoneGameV(std::vector<int> &stoneValue) {
    int n = stoneValue.size();
    std::vector dp(n, std::vector(n, -1));;
    std::vector pref(n + 1, 0);
    for (int i = 0; i < n; ++i)
        pref[i + 1] = pref[i] + stoneValue[i];
    return gameDp(dp, pref, stoneValue, 0, n - 1);
}

int problem_1563::gameDp(std::vector<std::vector<int>> &dp, std::vector<int> &pref, std::vector<int> &arr, int l, int r) {
    if (l == r)
        return 0;
    if (dp[l][r] != -1)
        return dp[l][r];
    int total = pref[r + 1] - pref[l];
    int pre = 0;
    int best = 0;
    for (int i = l; i < r; ++i)
    {
        pre += arr[i];
        int suf = total - pre;
        if (pre > suf)
            best = std::max(best, suf + gameDp(dp, pref, arr, i + 1, r));
        else if (pre < suf)
            best = std::max(best, pre + gameDp(dp, pref, arr, l, i));
        else
            best = std::max(best, std::max(pre + gameDp(dp, pref, arr, l, i), suf + gameDp(dp, pref, arr, i + 1, r)));
    }
    dp[l][r] = best;
    return best;
}
