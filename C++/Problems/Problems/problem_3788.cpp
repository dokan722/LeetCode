#include "problem_3788.h"

bool problem_3788::test() {
    std::vector nums { 10, -1, 3, -4, -5 };

    int expected = 17;

    auto result = maximumScore(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3788::maximumScore(std::vector<int> &nums) {
    int n = nums.size();
    long long s = 0;
    for (auto num : nums)
        s += num;
    long long result = INT_MIN;
    int m = INT_MAX;
    for (int i = n - 1; i > 0; --i)
    {
        m = std::min(m, nums[i]);
        s -= nums[i];
        result = std::max(result, s - m);
    }

    return result;
}
