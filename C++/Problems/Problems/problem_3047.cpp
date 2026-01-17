#include "problem_3047.h"

bool problem_3047::test() {
    std::vector<std::vector<int>> bottomLeft =  {  { 1, 1 },  { 2, 2 },  { 3, 1 } };
    std::vector<std::vector<int>> topRight =  {  { 3, 3 },  { 4, 4 },  { 6, 6 } };

    int expected = 1;

    auto result = largestSquareArea(bottomLeft, topRight);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3047::largestSquareArea(std::vector<std::vector<int>> &bottomLeft,
    std::vector<std::vector<int>> &topRight) {
    int n = bottomLeft.size();
    long long result = 0;
    for (int i = 0; i < n; ++i)
    {
        for (int j = i + 1; j < n; ++j)
        {
            int bottomBound = std::max(bottomLeft[i][1], bottomLeft[j][1]);
            int topBound = std::min(topRight[i][1], topRight[j][1]);
            int leftBound = std::max(bottomLeft[i][0], bottomLeft[j][0]);
            int rightBound = std::min(topRight[i][0], topRight[j][0]);
            int height = topBound - bottomBound;
            int width = rightBound - leftBound;
            long long side = std::min(height, width);
            if (side > 0)
                result = std::max(result, side * side);
        }
    }

    return result;
}
