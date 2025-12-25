#include "problem_973.h"

#include <algorithm>

bool problem_973::test() {
    std::vector<std::vector<int>> points {{ 1, 3 }, { -2, 2 } };
    int k = 1;

    std::vector<std::vector<int>> expected { { -2, 2 } };

    auto result = kClosest(points, k);

    print2DVector(result);

    return expected == result;
}

std::vector<std::vector<int>> problem_973::kClosest(std::vector<std::vector<int>> &points, int k) {
    std::sort(points.begin(), points.end(), [] (std::vector<int> &x, std::vector<int> &y)
        { return x[0] * x[0] + x[1] * x[1] < y[0] * y[0] + y[1] * y[1]; });

    std::vector<std::vector<int>> result(k);
    for (int i = 0; i < k; ++i)
        result[i] = points[i];

    return result;
}
