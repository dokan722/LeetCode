#include "problem_2104.h"

bool problem_2104::test() {
    std::vector nums {4, -2, -3, 4, 1};

    long expected = 59;

    auto result = subArrayRanges(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2104::subArrayRanges(std::vector<int> &nums) {
    int n = nums.size();
    long result = 0;
    for (int i = 0; i < n; i++)
    {
        int currMin = nums[i];
        int currMax = nums[i];
        for (int j = i + 1; j < n; j++)
        {
            currMin = std::min(currMin, nums[j]);
            currMax = std::max(currMax, nums[j]);
            result += currMax - currMin;
        }
    }

    return result;
}
