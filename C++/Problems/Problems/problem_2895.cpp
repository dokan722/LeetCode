#include "problem_2895.h"

#include <algorithm>

bool problem_2895::test() {
    std::vector processorTime { 10, 20 };
    std::vector tasks { 2, 3, 1, 2, 5, 8, 4, 3 };

    int expected = 23;

    auto result = minProcessingTime(processorTime, tasks);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2895::minProcessingTime(std::vector<int> &processorTime, std::vector<int> &tasks) {
    int n = processorTime.size();
    std::sort(processorTime.begin(), processorTime.end());
    std::sort(tasks.begin(), tasks.end());
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        result = std::max(result, processorTime[i] + tasks[4 * (n - i) - 1]);
    }

    return result;
}
