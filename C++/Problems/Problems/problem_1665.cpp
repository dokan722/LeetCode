#include "problem_1665.h"

bool problem_1665::test() {
    std::vector<std::vector<int>> tasks  { { 1, 2 }, { 2, 4 }, { 4, 8 } };

    int expected = 8;

    auto result = minimumEffort(tasks);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1665::minimumEffort(std::vector<std::vector<int>> &tasks) {
    int n = tasks.size();
    std::sort(tasks.begin(), tasks.end(), [](const std::vector<int>& a, const std::vector<int>& b) { return b[1] - b[0] < a[1] - a[0];});
    int total = 0;
    for (int i = 0; i < n; ++i)
        total += tasks[i][0];
    int cur = total;
    int result = total;
    for (int i = 0; i < n; ++i)
    {
        auto& t = tasks[i];
        result += std::max(0, t[1] - cur);
        cur = std::max(cur, t[1]);
        cur -= t[0];
    }
    return result;
}
