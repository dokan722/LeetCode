#include "problem_3440.h"

bool problem_3440::test() {
    auto eventTime = 10;
    std::vector startTime { 0, 3, 7, 9 };
    std::vector endTime { 1, 4, 8, 10 };

    auto expected = 6;
    auto result = maxFreeTime(eventTime, startTime, endTime);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3440::maxFreeTime(int eventTime, std::vector<int> &startTime, std::vector<int> &endTime) {
    auto n = startTime.size();
    auto nGaps = n + 1;
    auto sum = 0;
    std::vector<int> gaps(nGaps);
    for (int i = 0; i < nGaps; ++i)
        gaps[i] = getGapLength(i, startTime, endTime, eventTime);
    int max1 = INT_MIN;
    int max2 = INT_MIN;
    int max3 = INT_MIN;

    for (int gap : gaps)
    {
        if (gap > max1)
        {
            max3 = max2;
            max2 = max1;
            max1 = gap;
        }
        else if (gap > max2)
        {
            max3 = max2;
            max2 = gap;
        }
        else if (gap > max3)
        {
            max3 = gap;
        }
    }

    auto result = 0;
    for (int i = 0; i < n; ++i)
    {
        auto maxGap = max1;
        if (std::max(gaps[i], gaps[i + 1]) == max1)
        {
            if (std::min(gaps[i], gaps[i + 1]) == max2)
                maxGap = max3;
            else
                maxGap = max2;
        }
        auto currEvent = endTime[i] - startTime[i];
        auto freeTime = currEvent <= maxGap ? gaps[i] + gaps[i + 1] + currEvent : gaps[i] + gaps[i + 1];
        if (freeTime > result)
            result = freeTime;
    }

    return result;
}

int problem_3440::getGapLength(int i, std::vector<int> &startTime, std::vector<int> &endTime, int eventTime) {
    if (i == 0)
        return startTime[0];
    if (i == startTime.size())
        return eventTime - endTime[startTime.size() - 1];

    return startTime[i] - endTime[i - 1];
}
