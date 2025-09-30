#include "problem_1344.h"

bool problem_1344::test() {
    int hour = 12;
    int minutes = 30;

    double expected = 165;

    auto result = angleClock(hour, minutes);

    std::cout << result << std::endl;

    return std::abs(result - expected) < 1e-5;
}

double problem_1344::angleClock(int hour, int minutes) {
    double angle = std::abs(hour * 30 + minutes / 2.0 - minutes * 6);
    return angle < 180 ? angle : 360 - angle;
}
