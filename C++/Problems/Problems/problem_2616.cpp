#include "problem_2616.h"
#include <cmath>
#include <algorithm>

bool problem_2616::test() {
    std::vector nums { 3, 4, 2, 3, 2, 1, 2 };

    auto p = 3;

    auto expected = 1;

    auto result = minimizeMax(nums, p);

    return expected == result;
}

int problem_2616::minimizeMax(std::vector<int> &nums, int p) {
    std::ranges::sort(nums);
    auto left = 0;
    auto right = nums[nums.size() - 1] - nums[0];

    while (left < right)
    {
        auto mid = (left + right) / 2;
        auto count = countDiffs(nums, mid);
        if (count < p)
            left = mid + 1;
        else
            right = mid;
    }


    return left;
}

int problem_2616::countDiffs(std::vector<int> &nums, int maxDiff) {
    auto count = 0;
    for (int i = 0; i <  nums.size() - 1; i++)
    {
        if (std::abs(nums[i] - nums[i + 1]) <= maxDiff)
        {
            i++;
            count++;
        }
    }

    return count;
}
