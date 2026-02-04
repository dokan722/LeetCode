#include "problem_3818.h"

bool problem_3818::test() {
    std::vector nums { 1, -1, 2, 3, 3, 4, 5 };

    int expected = 4;

    auto result = minimumPrefixLength(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3818::minimumPrefixLength(std::vector<int> &nums) {
    int n = nums.size();
    for (int i = n - 2; i >= 0; --i)
    {
        if (nums[i] >= nums[i + 1])
            return i + 1;
    }

    return 0;
}
