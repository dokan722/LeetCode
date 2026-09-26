#include "problem_2855.h"

bool problem_2855::test() {
    std::vector nums { 3, 4, 5, 1, 2 };

    int expected = 2;

    auto result = minimumRightShifts(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2855::minimumRightShifts(std::vector<int> &nums) {
    int n = nums.size();
    int pos = nums[n - 1] >= nums[0] ? n - 1 : -1;
    for (int i = 0; i < n - 1; ++i)
    {
        if (nums[i] > nums[i + 1])
        {
            if (pos != -1)
                return -1;
            pos = i;
        }
    }

    return n - pos - 1;
}
