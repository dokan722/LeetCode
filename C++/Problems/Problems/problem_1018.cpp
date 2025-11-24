#include "problem_1018.h"

bool problem_1018::test() {
    std::vector nums { 0, 1, 1 };

    std::vector expected { true, false, false };

    auto result = prefixesDivBy5(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<bool> problem_1018::prefixesDivBy5(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<bool> result;
    int curr = 0;
    for (int i = 0; i < n; ++i)
    {
        curr = (2 * curr + nums[i]) % 10;
        result.push_back(curr == 5 || curr == 0);
    }

    return result;
}
