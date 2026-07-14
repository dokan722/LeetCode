#include "problem_3169.h"

bool problem_3169::test() {
    int days = 10;
    std::vector<std::vector<int>> meetings { { 5, 7 }, { 1, 3 }, { 9, 10 } };

    int expected = 2;

    auto result = countDays(days, meetings);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3169::countDays(int days, std::vector<std::vector<int>> &meetings) {
    std::sort(meetings.begin(), meetings.end(), [&](auto &a, auto &b) { return a[0] < b[0];});
    int cur = 1;
    int result = 0;
    for (auto m : meetings)
    {
        if (m[0] > cur)
            result += m[0] - cur;
        cur = std::max(cur, m[1] + 1);
    }
    result += days - cur + 1;
    return result;
}
