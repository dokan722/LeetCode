#include "problem_1051.h"

#include <algorithm>

bool problem_1051::test() {
    std::vector heights { 1, 1, 4, 2, 1, 3 };

    auto expected = 3;

    auto result = heightChecker(heights);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1051::heightChecker(std::vector<int> &heights) {
    std::vector sorted = heights;
    std::ranges::sort(sorted);
    auto result = 0;
    for (int i = 0; i < heights.size(); i++)
    {
        if (heights[i] != sorted[i])
            result++;
    }

    return result;
}
