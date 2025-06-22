#include "problem_334.h"

#include <iostream>
#include <ostream>

bool problem_334::test() {
    std::vector nums { 1, 2, 3, 4, 5 };

    auto expected = true;

    auto result = increasingTriplet(nums);

    std::cout << result << std::endl;

    return expected == result;
}

bool problem_334::increasingTriplet(std::vector<int> &nums) {
    auto first = INT_MAX;
    auto second = INT_MAX;

    for (int i = 0; i < nums.size(); ++i)
    {
        if (nums[i] <= first)
            first = nums[i];
        else if (nums[i] <= second)
            second = nums[i];
        else
            return true;
    }

    return false;
}
