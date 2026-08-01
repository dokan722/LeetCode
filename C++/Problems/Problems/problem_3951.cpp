#include "problem_3951.h"

bool problem_3951::test() {
    int n = 5;
    int brightness = 5;
    std::vector<std::vector<int>> intervals { { 6, 12 } };

    int expected = 14;

    auto result = minEnergy(n, brightness, intervals);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3951::minEnergy(int n, int brightness, std::vector<std::vector<int>> &intervals) {
    long long cost = (brightness + 2) / 3;
    std::sort(intervals.begin(), intervals.end(), [](std::vector<int> a, std::vector<int> b) { return a[0] == b[0] ? a[1] < b[1] : a[0] < b[0]; });
    long long result = 0;
    int th = 0;
    for (auto i : intervals)
    {
        if (th > i[1])
            continue;
        result += cost * (i[1] - std::max(i[0], th) + 1);
        th = i[1] + 1;
    }

    return result;
}
