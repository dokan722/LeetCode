#include "problem_3201.h"

bool problem_3201::test() {
    std::vector nums { 1, 2, 1, 1, 2, 1, 2 };

    auto expected = 6;

    auto result = maximumLength(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3201::maximumLength(std::vector<int> &nums) {
    int odds = 0;
    int changes = 1;
    auto odd = nums[0] % 2 == 1;
    if (odd)
        odds++;
    for (int i = 1; i < nums.size(); ++i)
    {
        auto currOdd = nums[i] % 2 == 1;
        if (currOdd)
            odds++;
        if (currOdd != odd)
        {
            changes++;
            odd = currOdd;
        }
    }

    return std::max(std::max(changes, odds), (int)nums.size() - odds);
}
