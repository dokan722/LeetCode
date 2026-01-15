#include "problem_1450.h"

bool problem_1450::test() {
    std::vector startTime { 1, 2, 3 };
    std::vector endTime { 3, 2, 7 };
    int queryTime = 4;

    int expected = 1;

    auto result = busyStudent(startTime, endTime, queryTime);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1450::busyStudent(std::vector<int> &startTime, std::vector<int> &endTime, int queryTime) {
    int n = startTime.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (startTime[i] <= queryTime && endTime[i] >= queryTime)
            result++;
    }

    return result;
}
