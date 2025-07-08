#include "problem_2335.h"

#include <algorithm>

bool problem_2335::test() {
    std::vector amount{ 1, 4, 2 };

    auto expected = 4;

    auto result = fillCups(amount);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2335::fillCups(std::vector<int> &amount) {
    std::sort(amount.begin(), amount.end());
    if (amount[2] > amount[0] + amount[1])
        return amount[2];

    auto cut = amount[1] - amount[0];
    auto rest = amount[0] - (amount[2] - cut) / 2;
    return rest + amount[2];
}
