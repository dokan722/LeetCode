#include "problem_123.h"

bool problem_123::test() {
    std::vector prices { 3, 3, 5, 0, 0, 3, 1, 4 };

    int expected = 6;

    auto result = maxProfit(prices);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_123::maxProfit(std::vector<int> &prices) {
    int n = prices.size();
    std::vector empty(3, 0);
    std::vector buying(3, -prices[0]);
    for (int i = 1; i < n; ++i)
    {
        empty[2] = std::max(empty[2], buying[2] + prices[i]);
        buying[2] = std::max(buying[2], empty[1] - prices[i]);
        empty[1] = std::max(empty[1], buying[1] + prices[i]);
        buying[1] = std::max(buying[1], empty[0] - prices[i]);
    }

    return empty[2];
}
