#include "problem_3363.h"

bool problem_3363::test() {
    std::vector<std::vector<int>> fruits { {1, 2, 3, 4},  {5, 6, 8, 7},  {9, 10, 11, 12},  {13, 14, 15, 16}};

    auto expected = 100;

    auto result = maxCollectedFruits(fruits);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3363::maxCollectedFruits(std::vector<std::vector<int>> &fruits) {
    int n = fruits.size();
    auto diagonal = 0;
    std::vector<std::vector<int>> dp(n);
    for (int i = 0; i < n; i++)
    {
        diagonal += fruits[i][i];
        dp[i] = std::vector(n, -1);
    }

    dp[n - 1][n - 1] = 0;
    auto lower = checkLower(fruits, dp, n, n - 1, 0, n - 1);
    auto upper = checkUpper(fruits, dp, n, 0, n - 1, n - 1);


    return diagonal + lower + upper;
}

int problem_3363::checkLower(std::vector<std::vector<int>> &fruits, std::vector<std::vector<int>> &dp, int n, int x,
    int y, int k) {
    if (x >= n || (k == 0 && x != y) || (k > 0 && x <= y))
        return -1;
    if (dp[x][y] != -1)
        return dp[x][y];

    auto best = std::max(std::max(checkLower(fruits, dp, n, x - 1, y + 1, k - 1), checkLower(fruits, dp, n, x, y + 1, k - 1)),
        checkLower(fruits, dp, n, x + 1, y + 1, k - 1));

    if (best < 0)
        dp[x][y] = INT_MIN;
    else
        dp[x][y] = fruits[x][y] + best;

    return dp[x][y];
}

int problem_3363::checkUpper(std::vector<std::vector<int>> &fruits, std::vector<std::vector<int>> &dp, int n, int x,
    int y, int k) {
    if (y >= n || (k == 0 && x != y) || (k > 0 && x >= y))
        return -1;
    if (dp[x][y] != -1)
        return dp[x][y];

    auto best = std::max(std::max(checkUpper(fruits, dp, n, x + 1, y - 1, k - 1), checkUpper(fruits, dp, n, x + 1, y, k - 1)),
        checkUpper(fruits, dp, n, x + 1, y + 1, k - 1));

    if (best < 0)
        dp[x][y] = INT_MIN;
    else
        dp[x][y] = fruits[x][y] + best;

    return dp[x][y];
}
