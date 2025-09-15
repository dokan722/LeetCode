#include "problem_1833.h"

#include <algorithm>

bool problem_1833::test() {
    std::vector costs { 1, 3, 2, 4, 1 };
    int coins = 7;

    int expected = 4;

    auto result = maxIceCream(costs, coins);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1833::maxIceCream(std::vector<int> &costs, int coins) {
    std::sort(costs.begin(), costs.end());

    int i = 0;
    while (i < costs.size() && costs[i] <= coins)
    {
        coins -= costs[i];
        i++;
    }

    return i;
}
