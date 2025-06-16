#include "problem_2016.h"

#include <iostream>
#include <ostream>

bool problem_2016::test() {
    std::vector nums  { 1, 2, 10, 5, 9 };


    auto expected = 9;

    auto result = maximumDifference(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2016::maximumDifference(std::vector<int> &nums) {
    int result = INT_MIN;

    auto minSoFar = INT_MAX;

    for (int i = 1; i < nums.size(); ++i)
    {
        if (nums[i - 1] < minSoFar)
            minSoFar = nums[i - 1];
        auto diff = nums[i] - minSoFar;
        if (diff > result)
            result = diff;
    }

    return result <= 0 ? -1 : result;
}
