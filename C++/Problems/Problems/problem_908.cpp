#include "problem_908.h"

bool problem_908::test() {
    std::vector nums {1, 3, 6 };
    int k = 3;

    int expected = 0;

    auto result = smallestRangeI(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_908::smallestRangeI(std::vector<int> &nums, int k) {
    int maxValue = nums[0], minValue = nums[0];
    for (int i = 1; i < nums.size(); ++i)
    {
        maxValue = std::max(maxValue, nums[i]);
        minValue = std::min(minValue, nums[i]);
    }
    return std::max(0, maxValue - minValue - 2 * k);
}
