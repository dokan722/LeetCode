#include "problem_1498.h"

#include <algorithm>
#include <cmath>
#include <iostream>
#include <ostream>

bool problem_1498::test() {
    std::vector nums  {2, 3, 3, 4, 6, 7};
    auto target = 12;

    auto expected = 61;

    auto result = numSubseq(nums, target);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1498::numSubseq(std::vector<int> &nums, int target) {
    std::sort(nums.begin(), nums.end());
    auto n = nums.size();
    auto mod = (int)std::pow(10, 9) + 7;
    std::vector powers(n, 1);
    for (int i = 1; i < n; ++i)
        powers[i] = (powers[i - 1] * 2) % mod;
    auto result = 0;
    auto left = 0;
    int right = nums.size() - 1;
    while (left <= right)
    {
        if (nums[left] + nums[right] <= target)
        {
            result = (result + powers[right - left]) % mod;
            left++;
        }
        else
            right--;

    }
    return result;
}
