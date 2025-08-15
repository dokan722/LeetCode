#include "problem_1561.h"

#include <algorithm>

bool problem_1561::test() {
    std::vector piles { 2, 4, 1, 2, 7, 8 };

    auto expected = 9;

    auto result = maxCoins(piles);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1561::maxCoins(std::vector<int> &piles) {
    int n = piles.size();
    std::ranges::sort(piles);

    auto sum = 0;

    for (int i = 0; i < n / 3; i++)
    {
        sum += piles[n - 2 - 2 * i];
    }

    return sum;
}
