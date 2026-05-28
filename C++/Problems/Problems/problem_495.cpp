#include "problem_495.h"

bool problem_495::test() {
    std::vector timeSeries { 1, 4 };
    int duration = 2;

    int expected = 4;

    auto result = findPoisonedDuration(timeSeries, duration);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_495::findPoisonedDuration(std::vector<int> &timeSeries, int duration) {
    int n = timeSeries.size();
    int result = 0;
    for (int i = 0; i < n - 1; ++i)
    {
        result += std::min(duration, timeSeries[i + 1] - timeSeries[i]);
    }

    return result + duration;
}
