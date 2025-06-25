#include "problem_1725.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_1725::test() {
    std::vector<std::vector<int>> rectangles { {5, 8},  {3, 9}, {5, 12}, {16, 5}};

    auto expected = 3;

    auto result = countGoodRectangles(rectangles);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1725::countGoodRectangles(std::vector<std::vector<int>> &rectangles) {
    auto max = 0;
    auto count = 0;
    for (auto r : rectangles)
    {
        auto side = std::min(r[0], r[1]);
        if (side == max)
            count++;
        else if (side > max)
        {
            max = side;
            count = 1;
        }
    }

    return count;
}
