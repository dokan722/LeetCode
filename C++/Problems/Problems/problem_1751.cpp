#include "problem_1751.h"

#include <algorithm>

bool problem_1751::test() {
    std::vector<std::vector<int>> events { { 1, 2, 4 }, { 3, 4, 3 }, { 2, 3, 10 } };

    auto k = 2;

    auto expected = 7;

    auto result = maxValue(events, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1751::maxValue(std::vector<std::vector<int>> &events, int k) {
    std::sort(events.begin(), events.end(), [](const std::vector<int> &a, const std::vector<int> &b) { return a[0] < b[0];});
    int n = events.size();
    std::vector<std::vector<int>> memory(k + 1, std::vector<int>(n, -1));
    auto result = checkScheduleRec(events, memory, 0, k);

    return result;
}

int problem_1751::checkScheduleRec(std::vector<std::vector<int>>& events, std::vector<std::vector<int>>& memory,
    int currEvent, int k) {
    if (k == 0 || currEvent == events.size())
        return 0;
    if (memory[k][currEvent] != -1)
        return memory[k][currEvent];
    auto nextFree = events[currEvent][1] + 1;
    auto left = currEvent;
    auto right = events.size() - 1;
    while (left < right)
    {
        int mid = (left + right + 1) / 2;
        if (events[mid][0] < nextFree)
            left = mid + 1;
        else
            right = mid;

    }

    memory[k][currEvent] =  std::max(events[currEvent][2] + checkScheduleRec(events, memory, left, k - 1),
        checkScheduleRec(events, memory, currEvent + 1, k));
    return memory[k][currEvent];
}
