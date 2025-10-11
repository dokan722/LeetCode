#include "problem_3186.h"

#include <map>

bool problem_3186::test() {
    std::vector power { 7, 1, 6, 6 };

    int expected = 13;

    int result = maximumTotalDamage(power);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_3186::maximumTotalDamage(std::vector<int> &power) {
    std::map<int, int> counts;
    for (auto p : power)
    {
        if (counts.contains(p))
            counts[p]++;
        else
            counts[p] = 1;
    }

    int n = counts.size();
    std::vector<int> values(n);
    int id = 0;
    for (auto count : counts)
    {
        values[id] = count.first;
        id++;
    }
    std::vector<long long> dp(n);
    long long result = 0;
    long long mx = 0;
    int j = 0;
    for (int i = 0; i < n; ++i)
    {
        int value = values[i];
        while (j < i && values[j] < value - 2)
        {
            mx = std::max(mx, dp[j]);
            j++;
        }
        dp[i] = mx + (long long)counts[value] * value;
        result = std::max(result, dp[i]);
    }

    return result;
}
