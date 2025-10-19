#include "problem_121.h"

bool problem_121::test() {
    std::vector prices { 7, 1, 5, 3, 6, 4 };

    int expected = 5;

    int result = maxProfit(prices);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_121::maxProfit(std::vector<int> &prices) {
    int n = prices.size();
    int currMin = prices[0];
    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        currMin = std::min(currMin, prices[i]);
        result = std::max(prices[i] - currMin, result);
    }

    return result;
}
