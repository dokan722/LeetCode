#include "problem_1029.h"

#include <algorithm>

bool problem_1029::test() {
    std::vector<std::vector<int>> costs { {259, 770},  {448, 54},  {926, 667},  {184, 139},  {840, 118},  {577, 469}};

    int expected = 1859;

    int result = twoCitySchedCost(costs);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1029::twoCitySchedCost(std::vector<std::vector<int>> &costs) {
    int n = costs.size() / 2;
    std::sort(costs.begin(), costs.end(), [](const std::vector<int>& a, const std::vector<int>& b) { return a[0] - a[1] < b[0] - b[1]; });
    int result = 0;
    for (int i = 0; i < n; ++i)
        result += costs[i][0] + costs[n + i][1];
    return result;
}
