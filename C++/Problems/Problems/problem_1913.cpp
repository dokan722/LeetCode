#include "problem_1913.h"

bool problem_1913::test() {
    std::vector nums { 4, 2, 5, 9, 7, 4, 8 };

    int expected = 64;

    auto result = maxProductDifference(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1913::maxProductDifference(std::vector<int> &nums) {
    int n = nums.size();
    int max1 = nums[0];
    int max2 = INT_MIN;
    int min1 = nums[0];
    int min2 = INT_MAX;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] >= max2)
        {
            if (nums[i] >= max1)
            {
                max2 = max1;
                max1 = nums[i];
            }
            else
                max2 = nums[i];
        }

        if (nums[i] <= min2)
        {
            if (nums[i] <= min1)
            {
                min2 = min1;
                min1 = nums[i];
            }
            else
                min2 = nums[i];
        }
    }

    return (max1 * max2) - (min1 * min2);
}
