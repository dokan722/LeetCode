#include "problem_808.h"
#include <cmath>

bool problem_808::test() {
    auto n = 800;

    auto expected = 0.71875;

    auto result = soupServings(n);

    std::cout << result << std::endl;

    return std::abs(result - expected) < 1e-5;
}

double problem_808::soupServings(int n) {
    int s = ceil(n / 25.0);
    if (s >= 200)
        return 1;
    std::vector dp(s + 1, std::vector<double>(s + 1, -1));

    return getProb(dp, s, s);
}

double problem_808::getProb(std::vector<std::vector<double>>& dp, int a, int b) {
    if (a <= 0 && b <= 0)
        return 0.5;
    if (a <= 0)
        return 1;
    if (b <= 0)
        return 0;
    if (dp[a][b] < 0)
        dp[a][b] = 0.25 * (getProb(dp, a - 4, b) + getProb(dp, a - 3, b - 1) + getProb(dp, a - 2, b - 2) + getProb(dp, a - 1, b - 3));
    return dp[a][b];
}
