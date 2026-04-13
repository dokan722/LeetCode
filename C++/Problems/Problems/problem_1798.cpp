#include "problem_1798.h"

bool problem_1798::test() {
    std::vector coins  { 1, 3 };

    int expected = 2;

    auto result = getMaximumConsecutive(coins);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1798::getMaximumConsecutive(std::vector<int> &coins) {
    std::sort(coins.begin(), coins.end());
    int result = 1;
    for (auto c : coins)
    {
        if (result < c)
            break;
        result += c;
    }

    return result;
}
