#include "problem_2110.h"

bool problem_2110::test() {
    std::vector prices { 3, 2, 1, 4 };

    int expected = 7;

    auto result = getDescentPeriods(prices);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_2110::getDescentPeriods(std::vector<int> &prices) {
    int n = prices.size();
    long long result = 0;
    int start = 0;
    for (int i = 1; i < n; ++i)
    {
        if (prices[i - 1] - prices[i] != 1)
        {
            long long l = i - start;
            result += l * (l + 1) / 2;
            start = i;
        }
    }
    long long fl = n - start;
    result += fl * (fl + 1) / 2;

    return result;
}