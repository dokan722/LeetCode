#include "problem_713.h"

bool problem_713::test() {
    std::vector nums { 10, 5, 2, 6 };
    int k = 100;

    int expected = 8;

    auto result = numSubarrayProductLessThanK(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_713::numSubarrayProductLessThanK(std::vector<int> &nums, int k) {
    if (k < 2)
        return 0;
    int n = nums.size();
    int l = 0;
    int result = 0;
    long long cur = 1;
    for (int i = 0; i < n; ++i)
    {
        cur *= nums[i];
        while (l < n && cur >= k)
        {
            cur /= nums[l];
            l++;
        }
        result += i - l + 1;
    }

    return result;
}
