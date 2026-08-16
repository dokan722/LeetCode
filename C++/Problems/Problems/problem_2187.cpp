#include "problem_2187.h"

bool problem_2187::test() {
    std::vector time { 1, 2, 3 };
    int totalTrips = 5;

    int expected = 3;

    auto result = minimumTime(time, totalTrips);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2187::minimumTime(std::vector<int> &time, int totalTrips) {
    long long left = 1;
    long long right = (long long)time[0] * totalTrips;
    while (left < right)
    {
        long long mid = (left + right) / 2;
        long long total = 0;
        for (auto t : time)
            total += mid / t;
        if (total >= totalTrips)
            right = mid;
        else
            left = mid + 1;
    }
    return left;
}
