#include "problem_1353.h"

#include <algorithm>

bool problem_1353::test() {
    std::vector<std::vector<int>> events { { 1, 1 }, { 1, 4 }, { 1, 10 } };

    auto expected = 3;

    auto result = maxEvents(events);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1353::maxEvents(std::vector<std::vector<int>> &events) {
    std::sort(events.begin(), events.end(),
        [](const std::vector<int> &a, const std::vector<int> &b) { return a[1] < b[1]; });
    auto maxDay = events[events.size() - 1][1];
    std::vector<bool> schedule(maxDay + 2, false);
    auto result = 0;
    for (auto e : events)
    {
        for (int i = e[0]; i <= e[1]; ++i)
        {
            if (!schedule[i])
            {
                schedule[i] = true;
                result++;
                break;
            }
        }
    }


    return result;
}
