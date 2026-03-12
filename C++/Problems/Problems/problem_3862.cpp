#include "problem_3862.h"

bool problem_3862::test() {
    std::vector nums  { 2, 1, 2 };

    int expected = 1;

    auto result = smallestBalancedIndex(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3862::smallestBalancedIndex(std::vector<int> &nums) {
    long long s = 0;
    for (auto num : nums)
        s += num;
    long long prod = 1;
    int i = nums.size() - 1;
    while (prod < s)
    {
        s -= nums[i];
        if (s == prod)
            return i;
        if (prod > s / nums[i])
            break;
        prod *= nums[i];
        --i;
    }

    return -1;
}
