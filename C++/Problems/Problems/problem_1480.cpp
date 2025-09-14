#include "problem_1480.h"

bool problem_1480::test() {
    std::vector nums { 1, 2, 3, 4 };

    std::vector expected { 1, 3, 6, 10 };

    auto result = runningSum(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_1480::runningSum(std::vector<int> &nums) {
    for (int i = 1; i < nums.size(); i++)
    {
        nums[i] += nums[i - 1];
    }

    return nums;
}
