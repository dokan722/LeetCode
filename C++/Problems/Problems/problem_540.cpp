#include "problem_540.h"

bool problem_540::test() {
    std::vector nums { 1, 1, 2, 3, 3, 4, 4, 8, 8 };

    int expected = 2;

    auto result = singleNonDuplicate(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_540::singleNonDuplicate(std::vector<int> &nums) {
    int n = nums.size();
    int l = 0;
    int r = n - 1;
    while (l < r)
    {
        int mid = (l + r) / 2;
        if (nums[mid] == nums[mid + 1])
        {
            if (mid % 2 == 0)
                l = mid + 2;
            else
                r = mid - 1;
        }
        else if (nums[mid] == nums[mid - 1])
        {
            if (mid % 2 == 1)
                l = mid + 1;
            else
                r = mid - 2;
        }
        else
            return nums[mid];
    }
    return nums[l];
}
