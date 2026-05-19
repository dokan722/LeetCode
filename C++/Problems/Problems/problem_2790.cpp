#include "problem_2790.h"

bool problem_2790::test() {
    std::vector nums { 2, 3, 7, 9, 3 };

    int expected = 21;

    auto result = maxArrayValue(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2790::maxArrayValue(std::vector<int> &nums) {
    int n = nums.size();
    long long result = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        if (result >= nums[i])
            result += nums[i];
        else
            result = nums[i];
    }

    return result;
}
