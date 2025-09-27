#include "problem_1365.h"

bool problem_1365::test() {
    std::vector nums { 8, 1, 2, 2, 3 };

    std::vector expected { 4, 0, 1, 1, 3 };

    auto result = smallerNumbersThanCurrent(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_1365::smallerNumbersThanCurrent(std::vector<int> &nums) {
    std::vector counts(101, 0);
    for (auto num : nums)
        counts[num]++;
    std::vector smaller(102, 0);
    smaller[0] = 0;
    for (int i = 1; i < 102; ++i)
        smaller[i] = counts[i - 1] + smaller[i - 1];

    for (int i = 0; i < nums.size(); ++i)
        nums[i] = smaller[nums[i]];

    return nums;
}
