#include "problem_3584.h"

bool problem_3584::test() {
    std::vector nums { -1, -9, 2, 3, -2, -3, 1 };
    int m = 1;

    int expected = 81;

    auto result = maximumProduct(nums, m);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3584::maximumProduct(std::vector<int> &nums, int m) {
    int n = nums.size();
    long long mx = INT_MIN;
    long long mn = INT_MAX;
    long long result = LONG_LONG_MIN;
    for (int i = m - 1; i < n; ++i)
    {
        int last = i - (m - 1);
        mx = std::max(mx, (long long)nums[last]);
        mn = std::min(mn, (long long)nums[last]);
        result = std::max(result, std::max(nums[i] * mx, nums[i] * mn));
    }

    return result;
}
