#include "problem_2419.h"

bool problem_2419::test() {
    std::vector nums { 1, 2, 3, 3, 2, 2 };

    auto expected = 2;

    auto result = longestSubarray(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2419::longestSubarray(std::vector<int> &nums) {
    int n = nums.size();
    int maxLen = 1;
    int maxNum = nums[0];
    int currLen = 1;

    for (int i = 1; i < n; i++)
    {
        if (nums[i] == nums[i - 1])
            currLen++;
        else
        {
            if (nums[i - 1] > maxNum || (nums[i - 1] == maxNum && currLen > maxLen))
            {
                maxNum = nums[i - 1];
                maxLen = currLen;
            }
            currLen = 1;
        }
    }
    if (nums[n - 1] > maxNum || (nums[n - 1] == maxNum && currLen > maxLen))
        maxLen = currLen;

    return maxLen;
}
