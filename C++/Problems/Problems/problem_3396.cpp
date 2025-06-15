#include "problem_3396.h"

#include <iostream>
#include <ostream>
#include <cmath>

bool problem_3396::test() {
    std::vector nums { 4, 5, 6, 4, 4 };


    auto expected = 2;

    auto result = minimumOperations(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3396::minimumOperations(std::vector<int> &nums) {
    bool found[100];
    int i = nums.size() - 1;

    for (; i >= 0; i--)
    {
        if (found[nums[i] - 1])
            break;

        found[nums[i] - 1] = true;
    }

    return (int)std::ceil((i + 1) / 3.0);
}
