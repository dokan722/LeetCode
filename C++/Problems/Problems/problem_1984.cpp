#include "problem_1984.h"

#include <algorithm>

bool problem_1984::test() {
    std::vector nums { 9, 4, 1, 7 };
    int k = 2;

    int expected = 2;

    auto result = minimumDifference(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1984::minimumDifference(std::vector<int> &nums, int k) {
    std::sort(nums.begin() , nums.end());
    int minDiff = INT_MAX; ;
    for (int i = k - 1; i < nums.size(); ++i)
    {
        minDiff = std::min(minDiff, nums[i] - nums[i - k + 1]);
    }

    return minDiff;
}
