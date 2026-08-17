#include "problem_4025.h"

bool problem_4025::test() {
    int period = 8;
    std::vector lights { 2, 3 };
    std::vector arrivalTime  { 2, 5, 8, 11 };

    int expected = 5;

    auto result = minPenalty(period, lights, arrivalTime);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_4025::minPenalty(int period, std::vector<int> &lights, std::vector<int> &arrivalTime) {
    int mx = 0;
    for (auto l : lights)
        mx = std::max(mx, l);
    int result = 0;
    for (auto a : arrivalTime)
    {
        int r = a % period;
        if (r >= mx)
            result = std::max(result, period - r);
    }

    return result;
}
