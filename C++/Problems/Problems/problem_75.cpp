#include "problem_75.h"

bool problem_75::test() {
    std::vector nums { 2, 0, 2, 1, 1, 0 };

    std::vector expected { 0, 0, 1, 1, 2, 2 };

    sortColors(nums);

    print1DVector(nums);

    return nums == expected;
}

void problem_75::sortColors(std::vector<int> &nums) {
    int left = 0;
    int mid = 0;
    int right = nums.size() - 1;
    while (mid < right)
    {
        if (nums[mid] == 0)
        {
            std::swap(nums[left], nums[mid]);
            left++;
            mid++;
        }
        else if (nums[mid] == 1)
            mid++;
        else
        {
            std::swap(nums[mid], nums[right]);
            right--;
        }
    }
}
