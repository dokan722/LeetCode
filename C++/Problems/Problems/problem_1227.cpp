#include "problem_1227.h"

bool problem_1227::test() {
    int n = 2;

    double expected = 0.5;

    auto result = nthPersonGetsNthSeat(n);

    std::cout << result << std::endl;

    return result == expected;
}

double problem_1227::nthPersonGetsNthSeat(int n) {
    if (n == 1)
        return 1.0;
    return 0.5;
}
