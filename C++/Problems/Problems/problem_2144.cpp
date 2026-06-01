#include "problem_2144.h"

bool problem_2144::test() {
    std::vector cost  { 1, 2, 3 };

    int expected = 5;

    auto result = minimumCost(cost);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2144::minimumCost(std::vector<int> &cost) {
    int n = cost.size();
    std::sort(cost.begin(), cost.end());
    int free = n % 3;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (i % 3 != free)
            result += cost[i];
    }

    return result;
}
