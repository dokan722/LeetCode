#include "problem_3516.h"

bool problem_3516::test() {
    auto x = 2;
    auto y = 7;
    auto z = 4;

    auto expected = 1;

    auto result = findClosest(x, y, z);

    return result == expected;
}

int problem_3516::findClosest(int x, int y, int z) {
    auto dist1 = std::abs(x - z);
    auto dist2 = std::abs(y - z);
    if (dist1 == dist2)
        return 0;
    return dist1 < dist2 ? 1 : 2;
}
