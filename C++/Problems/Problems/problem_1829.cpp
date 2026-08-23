#include "problem_1829.h"

bool problem_1829::test() {
    std::vector nums { 0, 1, 1, 3 };
    int maximumBit = 2;

    std::vector expected { 0, 3, 2, 3 };

    auto result = getMaximumXor(nums, maximumBit);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1829::getMaximumXor(std::vector<int> &nums, int maximumBit) {
    int n = nums.size();
    int cur = 0;
    std::vector<int> result(n);
    int mask = (1 << maximumBit) - 1;
    for (int i = 0; i < n; ++i)
    {
        cur ^= nums[i];
        result[n - 1 - i] = (mask ^ cur);
    }
    return result;
}
