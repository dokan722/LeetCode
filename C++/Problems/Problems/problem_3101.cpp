#include "problem_3101.h"

#include <iostream>
#include <ostream>

bool problem_3101::test() {
    std::vector nums { 0, 1, 1, 1 };

    auto expected = 5;

    auto result = countAlternatingSubarrays(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3101::countAlternatingSubarrays(std::vector<int> &nums) {
    auto prev = nums[0];
    nums[0] = 1;
    long result = 1;

    for (int i = 1; i < nums.size(); i++)
    {
        if (nums[i] != prev)
        {
            prev = nums[i];
            nums[i] = nums[i - 1] + 1;
        }
        else
        {
            prev = nums[i];
            nums[i] = 1;
        }

        result += nums[i];
    }

    return result;
}
