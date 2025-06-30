#include "problem_594.h"

#include <algorithm>
#include <iostream>
#include <bits/ostream.tcc>

bool problem_594::test() {
    std::vector nums { 1, 3, 2, 2, 5, 2, 3, 7 };

    auto expected = 5;

    auto result = findLHS(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_594::findLHS(std::vector<int> &nums) {
    std::sort(nums.begin(), nums.end());
    auto result = 0;
    auto count = 1;
    auto prevCount = 0;
    auto prev = nums[0];
    for (int i = 1; i < nums.size(); ++i)
    {
        if (nums[i] == prev)
            count++;
        else
        {
            if (prevCount != 0 && count + prevCount > result)
                result = count + prevCount;
            if (nums[i] - 1 != prev)
            {
                prevCount = 0;
            }
            else
            {
                prevCount = count;
            }
            count = 1;
            prev = nums[i];
        }
    }

    if (prevCount != 0 && count + prevCount > result)
        result = count + prevCount;

    return result;
}
