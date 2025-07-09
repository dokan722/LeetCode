#include "problem_3439.h"

bool problem_3439::test() {
    auto eventTime = 99;
    auto k = 1;
    std::vector startTime { 7, 21, 25 };
    std::vector endTime { 13, 25, 78 };

    auto expected = 21;
    auto result = maxFreeTime(eventTime, k, startTime, endTime);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3439::maxFreeTime(int eventTime, int k, std::vector<int> &startTime, std::vector<int> &endTime) {
    auto n = startTime.size();
    auto gaps = n + 1;
    auto sum = 0;
    for (int i = 0; i <= k && i < gaps; ++i)
        sum += getGapLength(i, startTime, endTime, eventTime);
    if (k >= n)
        return sum;
    auto result = sum;
    for (int i = 0; i < gaps - k - 1; ++i)
    {
        sum -= getGapLength(i, startTime, endTime, eventTime);
        sum += getGapLength(i + k + 1, startTime, endTime, eventTime);
        if (sum > result)
            result = sum;
    }

    return result;
}

int problem_3439::getGapLength(int i, std::vector<int> &startTime, std::vector<int> &endTime, int eventTime) {
    if (i == 0)
        return startTime[0];
    if (i == startTime.size())
        return eventTime - endTime[startTime.size() - 1];

    return startTime[i] - endTime[i - 1];
}
