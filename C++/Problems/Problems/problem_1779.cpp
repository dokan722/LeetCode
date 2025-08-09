#include "problem_1779.h"

bool problem_1779::test() {
    auto x = 3;
    auto y = 4;

    std::vector<std::vector<int>> points { { 1, 2 }, { 3, 1 }, { 2, 4 }, { 2, 3 }, { 4, 4 } };

    auto expected = 2;

    auto result = nearestValidPoint(x, y, points);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1779::nearestValidPoint(int x, int y, std::vector<std::vector<int>> &points) {
    auto minDist = INT_MAX;
    auto result = -1;
    for (int i = 0; i < points.size(); i++)
    {
        if (x != points[i][0] && y != points[i][1])
            continue;
        auto dist = std::abs(x - points[i][0]) + std::abs(y - points[i][1]);
        if (dist < minDist)
        {
            result = i;
            minDist = dist;
        }
    }

    return result;
}
