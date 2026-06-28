#include "problem_2909.h"

bool problem_2909::test() {
    std::vector nums { 8, 6, 1, 5, 3 };

    int expected = 9;

    auto result = minimumSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2909::minimumSum(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> rightMins(n);
    rightMins[n - 1] = nums[n - 1];
    for (int i = n - 2; i > 0; --i)
    {
        rightMins[i] = std::min(nums[i], rightMins[i + 1]);
    }
    int curMin = nums[0];
    int result = INT_MAX;
    for (int i = 1; i < n - 1; ++i)
    {
        if (nums[i] > curMin && nums[i] > rightMins[i + 1])
            result = std::min(result, curMin + nums[i] + rightMins[i + 1]);
        curMin = std::min(curMin, nums[i]);
    }

    return result == INT_MAX ? -1 : result;
}
