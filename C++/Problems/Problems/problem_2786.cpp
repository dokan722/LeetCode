#include "problem_2786.h"

bool problem_2786::test() {
    std::vector nums { 2, 3, 6, 1, 9, 2 };
    int x = 5;

    int expected = 13;

    auto result = maxScore(nums, x);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2786::maxScore(std::vector<int> &nums, int x) {
    int n = nums.size();
    long even = nums[0] % 2 == 0 ? nums[0] : -x;
    long odd = nums[0] % 2 == 1 ? nums[0] : -x;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] % 2 == 0)
            even = std::max(odd + nums[i] - x, even + nums[i]);
        else
            odd = std::max(even + nums[i] - x, odd + nums[i]);
    }

    return std::max(even, odd);
}
