#include "problem_605.h"

bool problem_605::test() {
    std::vector flowerbed { 1, 0, 0, 0, 1 };
    int n = 1;

    bool expected = true;

    auto result = canPlaceFlowers(flowerbed, n);

    return result == expected;
}

bool problem_605::canPlaceFlowers(std::vector<int> &flowerbed, int n) {
    int m = flowerbed.size();
    int last = -2;
    for (int i = 0; i < m; ++i)
    {
        if (flowerbed[i] == 1)
        {
            int l = i - last - 1;
            last = i;
            n -= (l - 1) / 2;
        }
    }
    n -= (m - last - 1) / 2;
    return n <= 0;
}
