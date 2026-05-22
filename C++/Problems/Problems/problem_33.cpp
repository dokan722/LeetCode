#include "problem_33.h"

bool problem_33::test() {
    std::vector nums { 4, 5, 6, 7, 0, 1, 2 };
    int target = 0;

    int expected = 4;

    auto result = search(nums, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_33::search(std::vector<int> &nums, int target) {
    int l = 0;
    int r = nums.size() - 1;
    while (l < r)
    {
        int mid = (l + r) / 2;
        if (nums[mid] == target)
            return mid;

        if (nums[mid] >= nums[l])
        {
            if (nums[mid] < target)
                l = mid + 1;
            else if (nums[l] <= target)
                r = mid - 1;
            else
                l = mid + 1;
        }
        else
        {
            if (target < nums[mid])
                r = mid - 1;
            else if (target <= nums[r])
                l = mid + 1;
            else
                r = mid - 1;

        }
    }
    return nums[l] == target ? l : -1;
}
