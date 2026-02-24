#include "problem_2865.h"

#include <stack>

bool problem_2865::test() {
    std::vector heights  { 2, 4, 5, 2, 5, 5, 2, 1, 1, 3 };

    int expected = 23;

    auto result = maximumSumOfHeights(heights);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2865::maximumSumOfHeights(std::vector<int> &heights) {
    int n = heights.size();
    std::vector<long long> scopes(n, 0);
    long long result = 0;
    std::stack<std::pair<int, long long>> stack;
    long long total = 0;
    for (int i = 0; i < n; ++i)
    {
        long long curr = heights[i];
        int last = i;
        while (!stack.empty() && stack.top().second >= curr)
        {
            total -= (long)(stack.top().second - curr) * (last - stack.top().first);
            last = stack.top().first;
            stack.pop();
        }
        stack.push(std::pair(last, curr));
        total += curr;
        scopes[i] = total;
    }
    while (!stack.empty())
        stack.pop();
    total = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        long long curr = heights[i];
        int last = i;
        while (!stack.empty() && stack.top().second >= curr)
        {
            total -= (long)(stack.top().second - curr) * (stack.top().first -last);
            last = stack.top().first;
            stack.pop();
        }
        stack.push(std::pair(last, curr));
        total += curr;
        result = std::max(result, total + scopes[i] - curr);
    }

    return result;
}
