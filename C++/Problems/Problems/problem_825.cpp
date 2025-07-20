#include "problem_825.h"

#include <cmath>

bool problem_825::test() {
    std::vector ages { 20, 30, 100, 110, 120 };
    auto expected = 3;

    auto result = numFriendRequests(ages);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_825::numFriendRequests(std::vector<int> &ages) {
    std::vector<int> counts(121);
    for (auto age : ages)
    {
        counts[age]++;
    }

    auto result = 0;
    for (auto i = 1; i <= 120; ++i)
    {
        auto x = 0.5 * i + 7;
        auto minAge = (int)std::ceil(x);
        auto start = minAge == x ? minAge + 1 : minAge;
        auto maxAge = i;
        for (int j = start; j < maxAge; ++j)
            result += counts[j] * counts[i];
        if (i >= start)
            result += std::max(counts[i] * (counts[i] - 1), 0);
    }

    return result;
}
