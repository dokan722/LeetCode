#include "problem_1749.h"

bool problem_1749::test() {
    std::vector nums { 2, -5, 1, -4, 3, -2 };

    int expected = 8;

    auto result = maxAbsoluteSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1749::maxAbsoluteSum(std::vector<int> &nums) {
    auto n = nums.size();
    auto maxPos = 0;
    auto maxNeg = 0;
    auto sumPos = 0;
    auto sumNeg = 0;
    for (int i = 0; i < n; ++i)
    {
        sumPos += nums[i];
        sumNeg += nums[i];
        sumNeg = std::min(0, sumNeg);
        sumPos = std::max(0, sumPos);
        maxPos = std::max(sumPos, maxPos);
        maxNeg = std::min(sumNeg, maxNeg);
    }

    return std::max(maxPos, std::abs(maxNeg));
}
