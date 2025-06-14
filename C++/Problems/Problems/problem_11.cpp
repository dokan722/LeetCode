#include "problem_11.h"

bool problem_11::test() {
    std::vector nums{ 1, 8, 6, 2, 5, 4, 8, 3, 7 };

    auto expected = 49;

    auto result = maxArea(nums);

    return expected == result;
}

int problem_11::maxArea(std::vector<int> &height) {
    auto maxWater = 0;
    auto left = 0;
    auto right = height.size() - 1;
    while (left < right)
    {
        auto water = (right - left) * std::min(height[left], height[right]);
        if (water > maxWater)
            maxWater = water;
        if (height[left] < height[right])
            left += 1;
        else
            right -= 1;
    }

    return maxWater;
}
