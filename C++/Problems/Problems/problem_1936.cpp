#include "problem_1936.h"

bool problem_1936::test() {
    std::vector rungs { 1, 3, 5, 10 };
    int dist = 2;

    int expected = 2;

    auto result = addRungs(rungs, dist);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1936::addRungs(std::vector<int> &rungs, int dist) {
    int th = dist;
    int result = 0;
    for (auto rung : rungs)
    {
        if (rung > th)
        {
            int left = rung - th;
            result += (left + dist - 1) / dist;
        }
        th = rung + dist;
    }

    return result;
}
