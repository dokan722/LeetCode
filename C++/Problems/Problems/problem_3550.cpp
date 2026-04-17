#include "problem_3550.h"

bool problem_3550::test() {
    std::vector nums { 1, 3, 2 };

    int expected = 2;

    auto result = smallestIndex(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3550::smallestIndex(std::vector<int> &nums) {
    int n = nums.size();
    for (int i = 0; i < n; ++i)
    {
        int num = nums[i];
        int s = 0;
        while (num > 0)
        {
            s += num % 10;
            num /= 10;
        }
        if (s == i)
            return s;
    }

    return -1;
}
