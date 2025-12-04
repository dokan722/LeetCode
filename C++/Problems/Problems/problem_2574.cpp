#include "problem_2574.h"

bool problem_2574::test() {
    std::vector nums { 10, 4, 8, 3 };

    std::vector expected { 15, 1, 11, 22 };

    auto result = leftRightDifference(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_2574::leftRightDifference(std::vector<int> &nums) {
    int n = nums.size();
    int sum = 0;
    for (int i = 0; i < n; ++i)
        sum += nums[i];
    std::vector<int> result(n);
    int curr = 0;
    for (int i = 0; i < n; ++i)
    {
        result[i] = std::abs(2 * curr - sum + nums[i]);
        curr += nums[i];
    }

    return result;
}
