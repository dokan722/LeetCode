#include "problem_1094.h"

bool problem_1094::test() {
    std::vector<std::vector<int>> trips  { { 2, 1, 5 }, { 3, 3, 7 } };
    int capacity = 4;

    bool expected = false;

    auto result = carPooling(trips, capacity);

    return expected == result;
}

bool problem_1094::carPooling(std::vector<std::vector<int>> &trips, int capacity) {
    std::vector sweep(1002, 0);
    int end = 0;
    for (auto& t : trips)
    {
        sweep[t[1]] += t[0];
        sweep[t[2]] -= t[0];
        end = std::max(end, t[2]);
    }
    int cur = 0;
    for (int i = 0; i <= end; ++i)
    {
        cur += sweep[i];
        if (cur > capacity)
            return false;
    }

    return true;
}
