#include "problem_583.h"

bool problem_583::test() {
    std::string word1 = "sea";
    std::string word2 = "eat";

    int expected = 2;

    auto result = minDistance(word1, word2);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_583::minDistance(std::string word1, std::string word2) {
    int n = word1.size();
    int m = word2.size();
    std::vector dp(n, std::vector(m, -1));
    return minDistRec(dp, word1, word2, 0, 0);
}

int problem_583::minDistRec(std::vector<std::vector<int>>& dp, std::string word1, std::string word2, int i, int j) {
    if (i >= word1.size())
        return word2.size() - j;
    if (j >= word2.size())
        return word1.size() - i;
    if (dp[i][j] != -1)
        return dp[i][j];
    int result;
    if (word1[i] == word2[j])
        result =  minDistRec(dp, word1, word2, i + 1, j + 1);
    else
        result = std::min(minDistRec(dp, word1, word2, i + 1, j) + 1, minDistRec(dp, word1, word2, i, j + 1) + 1);
    dp[i][j] = result;

    return result;
}
