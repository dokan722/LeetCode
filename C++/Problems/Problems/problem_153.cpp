#include "problem_153.h"

bool problem_153::test() {
    std::vector nums { 3, 4, 5, 1, 2 };

    int expected = 1;

    auto result = findMin(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_153::findMin(std::vector<int> &nums) {
    int n = nums.size();
    if (nums[0] < nums[n - 1])
        return nums[0];
    int left = 0;
    int right = n - 1;
    while (left < right)
    {
        int mid = (left + right + 1) / 2;
        if (nums[mid] < nums[right])
            right = mid;
        else
            left = mid;
    }

    return nums[left];
}
