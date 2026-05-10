#include "problem_2057.h"

bool problem_2057::test() {
    std::vector nums { 0, 1, 2 };

    int expected = 0;

    auto result = smallestEqual(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2057::smallestEqual(std::vector<int> &nums) {
    int n = nums.size();
    for (int i = 0; i < n; ++i)
    {
        if (i % 10 == nums[i])
            return i;
    }

    return -1;
}
