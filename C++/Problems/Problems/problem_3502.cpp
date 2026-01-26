#include "problem_3502.h"

bool problem_3502::test() {
    std::vector cost { 5, 3, 4, 1, 3, 2 };

    std::vector expected { 5, 3, 3, 1, 1, 1 };

    auto result = minCosts(cost);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3502::minCosts(std::vector<int> &cost) {
    int n = cost.size();
    std::vector<int> result(n);
    int min = cost[0];
    for (int i = 0; i < n; ++i)
    {
        min = std::min(min, cost[i]);
        result[i] = min;
    }

    return result;
}
