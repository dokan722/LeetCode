#include "problem_3379.h"

bool problem_3379::test() {
    std::vector nums { 3, -2, 1, 1 };

    std::vector expected { 1, 1, 1, 3 };

    auto result = constructTransformedArray(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3379::constructTransformedArray(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
        result[i] = nums[((i + nums[i]) % n + n) % n];
    return result;
}
