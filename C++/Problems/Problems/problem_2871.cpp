#include "problem_2871.h"

bool problem_2871::test() {
    std::vector nums { 1, 0, 2, 0, 1, 2 };

    int expected = 3;

    auto result = maxSubarrays(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2871::maxSubarrays(std::vector<int> &nums) {
    int result = 0;
    int mask = -1;
    int cur = mask;
    for (auto num : nums)
    {
        cur &= num;
        if (cur == 0)
        {
            result++;
            cur = mask;
        }
    }
    if (result == 0)
        return 1;
    return result;
}
