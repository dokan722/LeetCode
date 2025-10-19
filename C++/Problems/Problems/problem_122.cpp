#include "problem_122.h"

bool problem_122::test() {
    std::vector prices { 7, 1, 5, 3, 6, 4 };

    int expected = 7;

    int result = maxProfit(prices);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_122::maxProfit(std::vector<int> &prices) {
    int n = prices.size();
    int currMin = prices[0];
    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        if (currMin < prices[i])
            result += prices[i] - currMin;
        currMin = prices[i];
    }

    return result;
}
