#include "problem_1475.h"

#include <stack>

bool problem_1475::test() {
    std::vector prices { 8, 4, 6, 2, 3 };

    std::vector expected { 4, 2, 4, 2, 3 };

    auto result = finalPrices(prices);

    return expected == result;
}

std::vector<int> problem_1475::finalPrices(std::vector<int> &prices) {
    int n = prices.size();

    std::stack<int> stack;

    for (int i = 0; i < n; i++)
    {
        while (!stack.empty() && prices[stack.top()] >= prices[i]) {
            prices[stack.top()] -= prices[i];
            stack.pop();
        }
        stack.push(i);
    }

    return prices;
}
