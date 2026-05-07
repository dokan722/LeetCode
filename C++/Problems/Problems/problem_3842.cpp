#include "problem_3842.h"

bool problem_3842::test() {
    std::vector nums  { 10, 30, 20, 10 };

    std::vector expected  { 20, 30 };

    auto result = toggleLightBulbs(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3842::toggleLightBulbs(std::vector<int> &bulbs) {
    std::vector bb(101, false);
    for (auto b : bulbs)
        bb[b] = !bb[b];
    std::vector<int> result;
    for (int i = 0; i <= 100; ++i)
        if (bb[i])
            result.push_back(i);
    return result;
}
