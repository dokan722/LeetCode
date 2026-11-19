#include "problem_2275.h"

bool problem_2275::test() {
    std::vector candidates  { 16, 17, 71, 62, 12, 24, 14 };

    int expected = 4;

    auto result = largestCombination(candidates);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2275::largestCombination(std::vector<int> &candidates) {
    int result = 0;
    int maxBits = 24;
    for (int i = 0; i < maxBits; ++i)
    {
        int cur = 0;
        int bit = 1 << i;
        for (auto num : candidates)
        {
            if ((num & bit) == bit)
                cur++;
        }
        result = std::max(cur, result);
    }

    return result;
}
