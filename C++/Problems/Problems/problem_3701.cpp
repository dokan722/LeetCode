#include "problem_3701.h"

bool problem_3701::test() {
    std::vector nums { 1, 3, 5, 7 };

    int expected = -4;

    auto result = alternatingSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3701::alternatingSum(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (i % 2 == 0)
            result += nums[i];
        else
            result -= nums[i];
    }

    return result;
}
