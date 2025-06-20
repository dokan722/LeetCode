#include "problem_2679.h"

#include <algorithm>
#include <iostream>

bool problem_2679::test() {
    std::vector<std::vector<int>> matrix =  { { 7, 2, 1 },  { 6, 4, 2 }, { 6, 5, 3 }, { 3, 2, 1 } };

    auto expected = 15;

    auto result = matrixSum(matrix);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2679::matrixSum(std::vector<std::vector<int>> &nums) {
    auto n = nums.size();
    auto m = nums[0].size();
    for (int i = 0; i < n; ++i)
    {
        std::ranges::sort(nums[i]);
    }

    auto result = 0;

    for (int i = 0; i < m; ++i)
    {
        auto max = 0;
        for (int j = 0; j < n; ++j)
        {
            if (nums[j][i] > max)
                max = nums[j][i];
        }
        result += max;
    }

    return result;
}
