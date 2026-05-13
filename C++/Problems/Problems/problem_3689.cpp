#include "problem_3689.h"

bool problem_3689::test() {
    std::vector nums  { 1, 3, 2 };
    int k = 2;

    int expected = 4;

    auto result = maxTotalValue(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3689::maxTotalValue(std::vector<int> &nums, int k) {
    int mx = INT_MIN;
    int mn = INT_MAX;
    for (auto num : nums)
    {
        mx = std::max(mx, num);
        mn = std::min(mn, num);
    }

    return (long long)(mx - mn) * k;
}
