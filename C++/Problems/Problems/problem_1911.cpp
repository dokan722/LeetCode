#include "problem_1911.h"

bool problem_1911::test() {
    std::vector nums { 6, 2, 1, 2, 4, 5 };

    int expected = 10;

    auto result = maxAlternatingSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_1911::maxAlternatingSum(std::vector<int> &nums) {
    int n = nums.size();
    long long even = 0;
    long long odd = nums[0];
    for (int i = 1; i < n; ++i)
    {
        even = std::max(even, odd - nums[i]);
        odd = std::max(odd, even + nums[i]);
    }


    return std::max(even, odd);
}
