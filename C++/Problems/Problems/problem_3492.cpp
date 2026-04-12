#include "problem_3492.h"

bool problem_3492::test() {
    int n = 2;
    int w = 3;
    int maxWeight = 15;

    int expected = 4;

    auto result = maxContainers(n, w, maxWeight);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3492::maxContainers(int n, int w, int maxWeight) {
    int mc = maxWeight / w;
    return std::min(n * n, mc);
}
