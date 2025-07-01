#include "problem_1920.h"

#include <iostream>

bool problem_1920::test() {
    std::vector nums { 0, 2, 1, 5, 3, 4 };
    std::vector expected { 0, 1, 2, 4, 5, 3 };

    auto result = buildArray(nums);

    for (auto r : result)
        std::cout << r << ", ";
    std::cout << std::endl;

    return result == expected;
}

std::vector<int> problem_1920::buildArray(std::vector<int> &nums) {
    int n = nums.size();
    for (int i = 0; i < n; ++i)
    {
        nums[i] += 1000 * (nums[nums[i]] % 1000);
    }

    for (int i = 0; i < n; ++i)
    {
        nums[i] /= 1000;
    }
    return nums;
}
