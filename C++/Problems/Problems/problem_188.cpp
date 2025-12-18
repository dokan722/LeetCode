#include "problem_188.h"

bool problem_188::test() {
    std::vector prices { 3, 2, 6, 5, 0, 3 };
    int k = 2;

    int expected = 7;

    auto result = maxProfit(k, prices);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_188::maxProfit(int k, std::vector<int> &prices) {
    int n = prices.size();
    std::vector noneDp(k + 1, 0);
    std::vector buyingDp(k + 1, -prices[0]);
    buyingDp[0] = 0;

    for (int i = 1; i < n; i++)
    {
        for (int j = k; j > 0; --j)
        {
            noneDp[j] = std::max(noneDp[j], buyingDp[j] + prices[i]);
            buyingDp[j] = std::max(buyingDp[j], noneDp[j - 1] - prices[i]);
        }
    }

    return noneDp[k];
}
