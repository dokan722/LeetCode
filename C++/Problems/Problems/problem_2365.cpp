#include "problem_2365.h"

#include <unordered_map>

bool problem_2365::test() {
    std::vector tasks { 1, 2, 1, 2, 3, 1 };
    int space = 3;

    int expected = 9;

    auto result = taskSchedulerII(tasks, space);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2365::taskSchedulerII(std::vector<int> &tasks, int space) {
    long long result = 0;
    std::unordered_map<int, long long> th;
    for (auto t : tasks)
    {
        if (!th.contains(t))
            th[t] = 0L;
        result = std::max(th[t], result) + 1;
        th[t] = result + space;
    }

    return result;
}
