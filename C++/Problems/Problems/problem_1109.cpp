#include "problem_1109.h"

bool problem_1109::test() {
    std::vector<std::vector<int>> bookings { {1, 2, 10},  {2, 3, 20},  {2, 5, 25}};
    int n = 5;

    std::vector expected  { 10, 55, 45, 25, 25 };

    auto result = corpFlightBookings(bookings, n);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1109::corpFlightBookings(std::vector<std::vector<int>> &bookings, int n) {
    std::vector sweepArray(n + 1, 0);
    for (auto booking : bookings)
    {
        int first = booking[0] - 1;
        int last = booking[1] - 1;
        int seats = booking[2];
        sweepArray[first] += seats;
        sweepArray[last + 1] -= seats;
    }

    std::vector<int> result(n);
    int curBooked = 0;
    for (int i = 0; i < n; ++i)
    {
        curBooked += sweepArray[i];
        result[i] = curBooked;
    }

    return result;
}
