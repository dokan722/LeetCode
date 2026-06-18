#include "problem_3784.h"

bool problem_3784::test() {
    std::string s = "aabaac";
    std::vector cost { 1, 2, 3, 4, 1, 10 };

    int expected = 11;

    auto result = minCost(s, cost);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3784::minCost(std::string s, std::vector<int> &cost) {
    int n = s.size();
    long long total = 0;
    long long mx = 0;
    std::vector<long long> costs(26, 0);
    for (int i = 0; i < n; ++i)
    {
        costs[s[i] - 'a'] += cost[i];
        total += cost[i];
    }
    for (int i = 0; i < 26; ++i)
        mx = std::max(mx, costs[i]);
    return total - mx;
}
