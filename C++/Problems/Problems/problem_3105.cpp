#include "problem_3105.h"

bool problem_3105::test() {
    std::vector nums  { 1, 4, 3, 3, 2 };

    int expected = 2;

    auto result = longestMonotonicSubarray(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3105::longestMonotonicSubarray(std::vector<int> &nums) {
    int n = nums.size();
    int result = 1;
    int cur = 1;
    bool inc = true;
    for (int i = 1; i < n; ++i)
    {
        if (inc && nums[i] > nums[i - 1])
            cur++;
        else if (!inc && nums[i] < nums[i - 1])
            cur++;
        else
        {
            result = std::max(result, cur);
            inc = !inc;
            cur = 1 + (nums[i] != nums[i - 1] ? 1 : 0);
        }
    }
    result = std::max(result, cur);

    return result;
}
