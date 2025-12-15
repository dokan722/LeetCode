#include "problem_945.h"

#include <algorithm>

bool problem_945::test() {
    std::vector nums { 3, 2, 1, 2, 1, 7 };

    int expected = 6;

    auto result = minIncrementForUnique(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_945::minIncrementForUnique(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    int curr = -1;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] > curr)
            curr = nums[i];
        else
        {
            curr++;
            result += curr - nums[i];
        }
    }

    return result;
}
