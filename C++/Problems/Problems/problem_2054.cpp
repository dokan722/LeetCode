#include "problem_2054.h"

#include <algorithm>

bool problem_2054::test() {
    std::vector<std::vector<int>> events { { 1, 3, 2 }, { 4, 5, 2 }, { 2, 4, 3 } };

    int expected = 4;

    auto result = maxTwoEvents(events);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2054::maxTwoEvents(std::vector<std::vector<int>> &events) {
    std::vector<std::vector<int>> ts;
    for (auto &e : events)
    {
        ts.push_back(std::vector {e[0], 0, e[2]});
        ts.push_back(std::vector {e[1], 1, e[2]});
    }

    int result = 0;
    int maxFinished = 0;

    std::sort(ts.begin(), ts.end(), [] (std::vector<int> &a, std::vector<int> &b) { return a[0] == b[0] ? a[1] < b[1] : a[0] < b[0]; });
    for (auto &t : ts)
    {
        if (t[1] == 0)
            result = std::max(result, t[2] + maxFinished);
        else
            maxFinished = std::max(maxFinished, t[2]);
    }

    return result;
}
