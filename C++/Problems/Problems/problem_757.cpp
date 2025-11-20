#include "problem_757.h"

#include <algorithm>

bool problem_757::test() {
    std::vector<std::vector<int>> intervals { { 1, 3 }, { 3, 7 }, { 8, 9 } };

    int expected = 5;

    auto result = intersectionSizeTwo(intervals);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_757::intersectionSizeTwo(std::vector<std::vector<int>> &intervals) {
    std::sort(intervals.begin(), intervals.end(),
        [](const std::vector<int> &a, const std::vector<int> &b) { return a[1] == b[1] ? a[0] > b[0] : a[1] < b[1]; });
    int suf[2] { intervals[0][1] - 1, intervals[0][1]};
    int result = 2;
    for (auto inter : intervals)
    {
        int start = inter[0];
        int end = inter[1];
        if (start <= suf[0])
            continue;
        if (start > suf[1])
        {
            result += 2;
            suf[0] = end - 1;
            suf[1] = end;
        }
        else
        {
            result += 1;
            suf[0] = suf[1];
            suf[1] = end;
        }
    }

    return result;
}
