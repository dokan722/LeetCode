#include "problem_3025.h"

#include <algorithm>

bool problem_3025::test() {
    std::vector<std::vector<int>> points { { 3, 1 }, { 1, 3 }, { 1, 1 } };

    int expected = 2;

    int result = numberOfPairs(points);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3025::numberOfPairs(std::vector<std::vector<int>> &points) {
    int n = points.size();
    std::sort(points.begin(), points.end(), comparePoints);
    int result = 0;

    for (int i = 0; i < n - 1; ++i)
    {
        int maxX = INT_MAX;
        int maxY = INT_MAX;
        for (int j = i + 1; j < n; ++j)
        {
            if (points[j][0] <= points[i][0] && points[j][1] >= points[i][1] && points[j][0] < maxX && points[j][1] < maxY)
            {
                result++;
                maxX = points[j][0];
                maxY = points[j][1];
            }
        }
    }

    return result;
}

bool problem_3025::comparePoints(const std::vector<int>& x, const std::vector<int>& y) {
    if (x[0] != y[0])
        return x[0] > y[0];
    return y[1] > x[1];
}
