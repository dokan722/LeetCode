#include "problem_1232.h"

bool problem_1232::test() {
    std::vector<std::vector<int>> coordinates {{1, 2}, {2, 3}, {3, 4}, {4, 5}, {5, 6}, {6, 7}};

    bool expected = true;

    auto result = checkStraightLine(coordinates);

    return result == expected;
}

bool problem_1232::checkStraightLine(std::vector<std::vector<int>> &coordinates) {
    int n = coordinates.size();
    int x1 = coordinates[0][0];
    int x2 = coordinates[1][0];
    int y1 = coordinates[0][1];
    int y2 = coordinates[1][1];
    for (int i = 2; i < n; ++i)
    {
        int x = coordinates[i][0];
        int y = coordinates[i][1];
        if ((y - y2) * (x2 - x1) != (y2 - y1) * (x - x2))
            return false;
    }

    return true;
}
