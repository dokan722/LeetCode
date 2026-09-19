#include "problem_1401.h"

bool problem_1401::test() {
    int radius = 1;
    int xCenter = 0;
    int yCenter = 0;
    int x1 = 1;
    int y1 = -1;
    int x2 = 3;
    int y2 = 1;

    bool expected = true;

    auto result = checkOverlap(radius, xCenter, yCenter, x1, y1, x2, y2);

    return expected == result;
}

bool problem_1401::checkOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2) {
    int dx = std::max(x1, std::min(xCenter, x2)) - xCenter;
    int dy = std::max(y1, std::min(yCenter, y2)) - yCenter;

    return dx * dx + dy * dy <= radius * radius;
}
