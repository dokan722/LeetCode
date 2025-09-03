#include "problem_877.h"

bool problem_877::test() {
    std::vector piles { 7, 8, 8, 10 };

    int expected = true;

    int result = stoneGame(piles);

    return expected == result;
}

bool problem_877::stoneGame(std::vector<int> &piles) {
    int n = piles.size();
    std::vector dp(n, std::vector(n, INT_MIN));
    return stoneGameRec(piles, dp, 0, n - 1, true) > 0;
}

int problem_877::stoneGameRec(std::vector<int>& piles, std::vector<std::vector<int>>& dp, int i, int j, bool aliceTurn) {
    if (i == j)
        return -piles[i];
    if (dp[i][j] != INT_MIN)
        return dp[i][j];
    int fromLeft = stoneGameRec(piles, dp, i + 1, j, !aliceTurn) + (aliceTurn ? piles[i] : -piles[i]);
    int fromRight = stoneGameRec(piles, dp, i, j - 1, !aliceTurn) + (aliceTurn ? piles[j] : -piles[j]);
    dp[i][j] = aliceTurn ? std::max(fromLeft, fromRight) : std::min(fromLeft, fromRight);
    return dp[i][j];
}
