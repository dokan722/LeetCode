#include "problem_3789.h"

bool problem_3789::test() {
    int cost1 = 3;
    int cost2 = 2;
    int costBoth = 1;
    int need1 = 3;
    int need2 = 2;

    int expected = 3l;

    auto result = minimumCost(cost1, cost2, costBoth, need1, need2);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3789::minimumCost(int cost1, int cost2, int costBoth, int need1, int need2) {
    if (costBoth < cost1 && costBoth < cost2)
        return (long long)costBoth * std::max(need1, need2);
    if (cost1 + cost2 < costBoth)
        return (long long)cost1 * need1 + (long long)cost2 * need2;
    if (need1 < need2)
        return (long long)costBoth * need1 + (long long)std::min(costBoth, cost2) * (need2 - need1);
    return (long long)costBoth * need2 + (long long)std::min(costBoth, cost1) * (need1 - need2);
}
