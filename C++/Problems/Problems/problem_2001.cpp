#include "problem_2001.h"

#include <unordered_map>

bool problem_2001::test() {
    std::vector<std::vector<int>> rectangles { { 4, 8 }, { 3, 6 }, { 10, 20 }, { 15, 30 } };

    int expected = 6;

    auto result = interchangeableRectangles(rectangles);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2001::interchangeableRectangles(std::vector<std::vector<int>> &rectangles) {
    std::pmr::unordered_map<double, int> counts;
    long result = 0;
    for (auto const& r : rectangles)
    {
        auto val = (double)r[0] / r[1];
        if (counts.contains(val))
        {
            result += counts[val];
            counts[val]++;
        }
        else
            counts[val] = 1;
    }

    return result;
}
