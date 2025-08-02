#include "problem_2561.h"

#include <algorithm>
#include <unordered_map>

bool problem_2561::test() {
    std::vector basket1 { 4, 2, 2, 2 };
    std::vector basket2 { 1, 4, 1, 2 };

    long expected = 1;

    auto result = minCost(basket1, basket2);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_2561::minCost(std::vector<int> &basket1, std::vector<int> &basket2) {
    int n = basket1.size();
    std::pmr::unordered_map<int, int> counts1;
    std::pmr::unordered_map<int, int> counts2;
    auto minConst = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        if (counts1.contains(basket1[i]))
            counts1[basket1[i]]++;
        else
        {
            counts1[basket1[i]] = 1;
            counts2[basket1[i]] = 0;
        }
        if (counts2.contains(basket2[i]))
            counts2[basket2[i]]++;
        else
        {
            counts2[basket2[i]] = 1;
            counts1[basket2[i]] = 0;
        }
        if (basket1[i] < minConst)
            minConst = basket1[i];
        if (basket2[i] < minConst)
            minConst = basket2[i];
    }

    std::vector<int> first;
    std::vector<int> second;
    for (auto key : counts1)
    {
        int toSwap = counts1[key.first] - counts2[key.first];
        if (toSwap % 2 != 0)
            return -1;
        if (toSwap > 0)
            first.insert(first.end(), toSwap / 2, key.first);
        else if (toSwap < 0)
            second.insert(second.end(), -toSwap / 2, key.first);
    }
    std::sort(first.begin(), first.end());
    std::sort(second.begin(), second.end());

    long long result = 0;
    int m = first.size();
    for (int i = 0; i < m; i++)
    {
        result += std::min(std::min(first[i], second[m - 1 - i]), 2 * minConst);
    }

    return result;
}

