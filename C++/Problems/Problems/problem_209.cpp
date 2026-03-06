#include "problem_209.h"

bool problem_209::test() {
    int target = 7;
    std::vector nums  { 2, 3, 1, 2, 4, 3 };

    int expected = 2;

    auto result = minSubArrayLen(target, nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_209::minSubArrayLen(int target, std::vector<int> &nums) {
    int n = nums.size();
    int r = 0;
    int sum = 0;
    int result = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        while (r < n && sum < target)
        {
            sum += nums[r];
            r++;
        }
        if (r >= n && sum < target)
            break;
        result = std::min(result, r - i);
        sum -= nums[i];
    }

    return result != INT_MAX ? result : 0;
}
