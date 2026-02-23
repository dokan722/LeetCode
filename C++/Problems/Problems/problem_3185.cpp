#include "problem_3185.h"

#include <unordered_map>

bool problem_3185::test() {
    std::vector hours { 12, 12, 30, 24, 24 };

    int expected = 2;

    auto result = countCompleteDayPairs(hours);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3185::countCompleteDayPairs(std::vector<int> &hours) {
    long long result = 0;
    std::unordered_map<int, int> counts;
    for (auto hour : hours)
    {
        int rem = hour % 24;
        int req = (24 - rem) % 24;
        if (counts.contains(req))
            result += counts[req];
        if (counts.contains(rem))
            counts[rem]++;
        else
            counts[rem] = 1;
    }

    return result;
}
