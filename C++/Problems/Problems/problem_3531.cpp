#include "problem_3531.h"

bool problem_3531::test() {
    int n = 3;
    std::vector<std::vector<int>> buildings { { 1, 2 }, { 2, 2 }, { 3, 2 }, { 2, 1 }, { 2, 3 } };

    int expected = 1;

    auto result = countCoveredBuildings(n, buildings);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3531::countCoveredBuildings(int n, std::vector<std::vector<int>> &buildings) {
    std::vector maxX(n + 1, 0);
    std::vector maxY (n + 1, 0);
    std::vector minX(n + 1, INT_MAX);
    std::vector minY(n + 1, INT_MAX);

    for (auto b : buildings)
    {
        maxX[b[1]] = std::max(maxX[b[1]], b[0]);
        maxY[b[0]] = std::max(maxY[b[0]], b[1]);
        minX[b[1]] = std::min(minX[b[1]], b[0]);
        minY[b[0]] = std::min(minY[b[0]], b[1]);
    }

    int result = 0;
    for (auto b : buildings)
    {
        if (maxX[b[1]] > b[0] && minX[b[1]] < b[0] && maxY[b[0]] > b[1] && minY[b[0]] < b[1])
            result++;
    }

    return result;
}
