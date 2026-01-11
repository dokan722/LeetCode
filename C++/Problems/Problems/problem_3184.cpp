#include "problem_3184.h"

bool problem_3184::test() {
    std::vector hours { 12, 12, 30, 24, 24 };

    int expected = 2;

    auto result = countCompleteDayPairs(hours);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3184::countCompleteDayPairs(std::vector<int> &hours) {
    std::vector rests(24, 0);
    int result = 0;
    for (auto hour : hours)
    {
        int rem = hour % 24;
        int missing = (24 - rem) % 24;
        result += rests[missing];
        rests[rem]++;
    }

    return result;
}
