#include "problem_2279.h"

#include <algorithm>

bool problem_2279::test() {
    std::vector capacity { 2, 3, 4, 5 };
    std::vector rocks { 1, 2, 4, 4 };
    int additionalRocks = 2;

    int expected = 3;

    auto result = maximumBags(capacity, rocks, additionalRocks);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2279::maximumBags(std::vector<int> &capacity, std::vector<int> &rocks, int additionalRocks) {
    int n = capacity.size();
    std::vector<int> space(n);
    for (int i = 0; i < n; ++i)
    {
        space[i] = capacity[i] - rocks[i];
    }
    std::sort(space.begin(), space.end());
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (space[i] == 0 || additionalRocks >= space[i])
        {
            additionalRocks -= space[i];
            result++;
        }
        else
        {
            return result;
        }
    }

    return result;
}
