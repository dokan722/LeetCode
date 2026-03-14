#include "problem_1288.h"

bool problem_1288::test() {
    std::vector<std::vector<int>> intervals  { { 1, 4 }, { 3, 6 }, { 2, 8 } };

    int expected = 2;

    auto result = removeCoveredIntervals(intervals);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1288::removeCoveredIntervals(std::vector<std::vector<int>> &intervals) {
    std::sort(intervals.begin(), intervals.end(), [](std::vector<int> &a, std::vector<int> &b) { return a[0] == b[0] ? b[1] < a[1] : a[0] < b[0]; });
    int end = -1;
    int result = 0;
    for (auto interval : intervals)
    {
        if (interval[1] > end)
        {
            end = interval[1];
            result++;
        }
    }

    return result;
}
