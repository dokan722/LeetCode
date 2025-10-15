#include "problem_3350.h"

bool problem_3350::test() {
    std::vector nums { 2, 5, 7, 8, 9, 2, 3, 4, 3, 1 };

    int expected = 3;

    auto result = maxIncreasingSubarrays(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3350::maxIncreasingSubarrays(std::vector<int> &nums) {
    int n = nums.size();
    int l = 1;
    int prev = 0;
    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i - 1] >= nums[i])
        {
            result = std::max(result, l / 2);
            prev = l;
            l = 0;
        }

        l++;
        result = std::max(result, std::min(l, prev));
    }
    result = std::max(result, l / 2);

    return result;
}
