#include "problem_1039.h"

bool problem_1039::test() {
    std::vector values { 1, 3, 1, 4, 1, 5 };

    int expected = 13;

    auto result = minScoreTriangulation(values);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1039::minScoreTriangulation(std::vector<int> &values) {
    int n = values.size();
    std::vector<std::vector<int>> dp(n, std::vector<int>(n, -1));
    return minScoreRec(0, n - 1, values, dp);
}

int problem_1039::minScoreRec(int left, int right, std::vector<int> &values, std::vector<std::vector<int>> &dp) {
    if (left > right - 2)
        return 0;
    if (dp[left][right] == -1)
    {
        int minScore = INT_MAX;
        for (int i = left + 1; i < right; ++i)
        {
            minScore = std::min(minScore,
                minScoreRec(left, i, values, dp) + values[left] * values[right] * values[i] +
                minScoreRec(i, right, values, dp));
        }
        dp[left][right] = minScore;
    }

    return dp[left][right];
}
