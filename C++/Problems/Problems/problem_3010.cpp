#include "problem_3010.h"

bool problem_3010::test() {
    std::vector nums { 10, 3, 1, 1 };

    int expected = 12;

    auto result = minimumCost(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3010::minimumCost(std::vector<int> &nums) {
    int n = nums.size();
    int m = std::min(nums[1], nums[2]);
    int sm = std::max(nums[1], nums[2]);
    for (int i = 3; i < n; ++i)
    {
        if (nums[i] < m)
        {
            sm = m;
            m = nums[i];
        }
        else if (nums[i] < sm)
        {
            sm = nums[i];
        }
    }

    return nums[0] + m + sm;
}
