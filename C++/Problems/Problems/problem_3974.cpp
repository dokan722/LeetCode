#include "problem_3974.h"

bool problem_3974::test() {
    std::vector nums { 6, 1, 2, 9 };
    int k = 3;
    int mul = 2;

    int expected = 26;

    auto result = maxSum(nums, k, mul);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3974::maxSum(std::vector<int> &nums, int k, int mul) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    long result = 0;
    for (int i = 0; i < k; ++i)
    {
        if (mul > 1)
        {
            result += (long long)nums[n - i - 1] * mul;
            mul--;
        }
        else
            result += nums[n - i - 1];
    }

    return result;
}
