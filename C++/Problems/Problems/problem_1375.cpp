#include "problem_1375.h"

bool problem_1375::test() {
    std::vector flips { 3, 2, 4, 1, 5 };

    int expected = 2;

    auto result = numTimesAllBlue(flips);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1375::numTimesAllBlue(std::vector<int> &flips) {
    int n = flips.size();
    int result = 0;
    int last = -1;
    for (int i = 0; i < n; ++i)
    {
        last = std::max(last, flips[i]);
        if (last == i + 1)
            result++;
    }

    return result;
}
