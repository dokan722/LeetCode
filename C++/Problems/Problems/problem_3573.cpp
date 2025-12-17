#include "problem_3573.h"

bool problem_3573::test() {
    std::vector prices { 12, 16, 19, 19, 8, 1, 19, 13, 9 };
    int k = 3;

    int expected = 36;

    auto result = maximumProfit(prices, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3573::maximumProfit(std::vector<int> &prices, int k) {
    int n = prices.size();
    std::vector<long long> noneDp(k + 1, 0);
    std::vector<long long> sellingDp(k + 1, prices[0]);
    std::vector<long long> buyingDp(k + 1, -prices[0]);
    sellingDp[0] = 0;
    buyingDp[0] = 0;

    for (int i = 1; i < n; i++)
    {
        for (int j = k; j > 0; --j)
        {
            noneDp[j] = std::max(noneDp[j], std::max(buyingDp[j] + prices[i], sellingDp[j] - prices[i]));
            sellingDp[j] = std::max(sellingDp[j], noneDp[j - 1] + prices[i]);
            buyingDp[j] = std::max(buyingDp[j], noneDp[j - 1] - prices[i]);
        }
    }

    return noneDp[k];
}
