#include "problem_812.h"

bool problem_812::test() {
    std::vector<std::vector<int>> points {  { 0, 0 },  { 0, 1 }, { 1, 0 }, { 0, 2 }, { 2, 0 } };

    double expected = 2.0;

    auto result = largestTriangleArea(points);

    std::cout << result << std::endl;

    return expected == result;
}

double problem_812::largestTriangleArea(std::vector<std::vector<int>> &points) {
    int n = points.size();
    double result = 0.0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = i + 1; j < n; ++j)
        {
            for (int k = j + 1; k < n; ++k)
                result = std::max(result, std::abs((points[j][0] - points[i][0]) * (points[k][1] - points[i][1])
                                                   - (points[j][1] - points[i][1]) *
                                                   (points[k][0] - points[i][0])) / 2.0);
        }
    }

    return result;
}
