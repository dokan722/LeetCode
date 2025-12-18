#include "problem_3652.h"

bool problem_3652::test() {
    std::vector prices { 4, 2, 8 };
    std::vector strategy { -1, 0, 1 };
    int k = 2;

    int expected = 10;

    auto result = maxProfit(prices, strategy, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3652::maxProfit(std::vector<int> &prices, std::vector<int> &strategy, int k) {
    int n = prices.size();
    int half = k / 2;
    long total = 0;
    long currDiff = 0;
    long bestDiff = 0;
    for (int i = 0; i < n; ++i)
    {
        int curr = prices[i] * strategy[i];
        total += curr;
        currDiff += prices[i] - curr;
        if (i >= half)
        {
            currDiff -= prices[i - half];
        }
        if (i >= k - 1)
        {
            if (i >= k)
                currDiff += prices[i - k] * strategy[i - k];
            bestDiff = std::max(bestDiff, currDiff);
        }
    }

    return total + bestDiff;
}
