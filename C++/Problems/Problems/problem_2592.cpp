#include "problem_2592.h"

#include <algorithm>

bool problem_2592::test() {
    std::vector nums { 1, 3, 5, 2, 1, 3, 1 };

    int expected = 4;

    auto result = maximizeGreatness(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2592::maximizeGreatness(std::vector<int> &nums) {
    int n = nums.size();
    if (n < 2)
        return 0;
    std::sort(nums.begin(), nums.end());
    int greatness = 0;
    int start = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] != nums[i - 1])
        {
            int l = i - start;
            greatness = std::min(greatness + l, start);
            start = i;
        }
    }

    int fl = n - start;
    greatness = std::min(greatness + fl, start);

    return greatness;
}
