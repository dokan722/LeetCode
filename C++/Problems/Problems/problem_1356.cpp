#include "problem_1356.h"

#include <algorithm>

bool problem_1356::test() {
    std::vector nums  { 0, 1, 2, 3, 4, 5, 6, 7, 8 };

    std::vector expected  { 0, 1, 2, 4, 8, 3, 5, 6, 7 };

    auto result = sortByBits(nums);

    return expected == result;
}

std::vector<int> problem_1356::sortByBits(std::vector<int> &arr) {
    std::sort(arr.begin(), arr.end(), compareBits);
    return arr;
}

bool problem_1356::compareBits(int &x, int &y) {
    auto xBits = std::popcount((unsigned)x);
    auto yBits = std::popcount((unsigned)y);

    if (xBits == yBits)
        return x < y;
    return xBits < yBits;
}
