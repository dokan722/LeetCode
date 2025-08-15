#include "problem_3232.h"

bool problem_3232::test() {
    std::vector nums { 1, 2, 3, 4, 10 };

    auto expected = false;

    auto result = canAliceWin(nums);

    return result == expected;
}

bool problem_3232::canAliceWin(std::vector<int> &nums) {
    auto sumDigit = 0;
    auto sumOther = 0;
    for (auto i = 0; i < nums.size(); i++)
    {
        if (nums[i] < 10)
            sumDigit += nums[i];
        else
            sumOther += nums[i];
    }

    return sumDigit != sumOther;
}
