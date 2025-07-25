#include "problem_2274.h"

#include <algorithm>

bool problem_2274::test() {
    int bottom = 2;
    int top = 9;
    std::vector special { 4, 6 };

    int expected = 3;

    auto result = maxConsecutive(bottom, top, special);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2274::maxConsecutive(int bottom, int top, std::vector<int> &special) {
    auto start = bottom;
    std::sort(special.begin(), special.end());
    auto max = INT_MIN;
    for (auto s : special)
    {
        auto len = s - start;
        if (len > max)
            max = len;
        start = s + 1;
    }

    auto last = top - start + 1;

    return std::max(last, max);
}
