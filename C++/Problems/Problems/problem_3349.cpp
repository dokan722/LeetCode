#include "problem_3349.h"

bool problem_3349::test() {
    std::vector nums { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 };
    int k = 3;

    bool expected = true;

    auto result = hasIncreasingSubarrays(nums, k);

    return expected == result;
}

bool problem_3349::hasIncreasingSubarrays(std::vector<int> &nums, int k) {
    if (k == 1)
        return true;
    int n = nums.size();
    bool firstFound = false;
    int len = 1;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] <= nums[i - 1])
        {
            if (len < k)
                firstFound = false;
            len = 0;
        }

        len++;
        if (len % k == 0)
        {
            if (firstFound)
                return true;
            firstFound = true;
        }
    }

    return false;
}
