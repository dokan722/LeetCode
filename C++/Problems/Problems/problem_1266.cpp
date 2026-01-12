#include "problem_1266.h"

bool problem_1266::test() {
    std::vector<std::vector<int>> points =  {  { 1, 1 },  { 3, 4 },  { -1, 0 } };

    int expected = 7;

    auto result = minTimeToVisitAllPoints(points);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1266::minTimeToVisitAllPoints(std::vector<std::vector<int>> &points) {
    int n = points.size();

    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        result += std::max(std::abs(points[i][0] - points[i - 1][0]), std::abs(points[i][1] - points[i - 1][1]));
    }

    return result;
}
