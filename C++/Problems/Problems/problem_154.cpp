#include "problem_154.h"

bool problem_154::test() {
    std::vector nums { 1, 3, 5 };

    int expected = 1;

    auto result = findMin(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_154::findMin(std::vector<int> &nums) {
    int n = nums.size();
    if (n == 1)
        return nums[0];
    if (nums[0] < nums[n - 1])
        return nums[0];
    int l = 1;
    int r = n - 1;
    while (l < r && nums[l] == nums[r])
        l++;
    while (l < r)
    {
        int mid = (l + r) / 2;
        if (nums[mid - 1] > nums[mid])
            return nums[mid];
        if (nums[mid] <= nums[r])
            r = mid;
        else
            l = mid + 1;
    }

    return nums[l];
}
