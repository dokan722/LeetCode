#include "problem_3314.h"

bool problem_3314::test() {
    std::vector nums { 2, 3, 5, 7 };

    std::vector expected { -1, 1, 4, 3 };

    auto result = minBitwiseArray(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_3314::minBitwiseArray(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == 2)
            result[i] = -1;
        else
            result[i] = nums[i] - (((nums[i] + 1) & -(nums[i] + 1)) >> 1);
    }

    return result;
}
