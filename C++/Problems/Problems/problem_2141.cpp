#include "problem_2141.h"

#include <algorithm>

bool problem_2141::test() {
    int n = 2;
    std::vector batteries { 3, 3, 3 };

    int expected = 4;

    auto result = maxRunTime(n, batteries);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_2141::maxRunTime(int n, std::vector<int> &batteries) {
    int m = batteries.size();
    std::sort(batteries.begin(), batteries.end());
    int start = m - n;
    long long restSum = 0;
    for (int i = 0; i < start; ++i)
        restSum += batteries[i];

    for (int i = start; i < m - 1; ++i)
    {
        long toFill = (batteries[i + 1] - batteries[i]) * (i - start + 1);
        if (restSum > toFill)
            restSum -= toFill;
        else
            return batteries[i] + restSum / (i - start + 1);
    }

    return batteries[m - 1] + restSum / n;
}
