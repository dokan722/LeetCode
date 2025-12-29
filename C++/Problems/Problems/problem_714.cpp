#include "problem_714.h"

bool problem_714::test() {
    std::vector prices { 1, 3, 2, 8, 4, 9 };
    int fee = 2;

    int expected = 8;

    int result = maxProfit(prices, fee);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_714::maxProfit(std::vector<int> &prices, int fee) {
    int n = prices.size();
    int maxNone = 0;
    int maxBought = -prices[0] - fee;
    for (int i = 0; i < n; ++i)
    {
        maxNone = std::max(maxNone, maxBought + prices[i]);
        maxBought = std::max(maxBought, maxNone - prices[i] - fee);
    }

    return maxNone;
}
