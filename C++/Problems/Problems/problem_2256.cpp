#include "problem_2256.h"

bool problem_2256::test() {
    std::vector nums { 2, 5, 3, 9, 5, 3 };

    int expected = 3;

    auto result = minimumAverageDifference(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2256::minimumAverageDifference(std::vector<int> &nums) {
    int n = nums.size();
    long s = 0;
    for (auto num : nums)
        s += num;
    long cur = 0;
    long best = INT_MAX;
    int result = 0;
    for (int i = 0; i < n - 1; ++i)
    {
        cur += nums[i];
        long pre = cur / (i + 1);
        long suf = (s - cur) / (n - i - 1);
        long val = std::abs(pre - suf);
        if (val < best)
        {
            best = val;
            result = i;
        }
    }
    if (s / n < best)
        result = n - 1;

    return result;
}
