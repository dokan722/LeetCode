#include "problem_1893.h"

#include <iostream>
#include <ostream>

bool problem_1893::test() {
    std::vector<std::vector<int>> ranges = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

    auto left = 2;
    auto right = 5;
    auto expected = true;

    auto result = isCovered(ranges, left, right);

    std::cout << result << std::endl;

    return result == expected;
}

bool problem_1893::isCovered(std::vector<std::vector<int>> &ranges, int left, int right) {
    bool covered[50];
    for (auto range : ranges)
    {
        for (int i = range[0] - 1; i <= range[1] - 1; i++)
            covered[i] = true;
    }

    for (int i = left - 1; i <= right - 1; ++i)
    {
        if (!covered[i])
            return false;
    }

    return true;
}
