#include "problem_45.h"

bool problem_45::test() {
    std::vector nums { 2, 3, 1, 1, 4 };

    int expected = 2;

    auto result = jump(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_45::jump(std::vector<int> &nums) {
    int n = nums.size();
    int maxReachable = 0;
    int curPos = 0;
    int jumps = 0;
    for (int i = 0; i < n; ++i)
    {
        if (i > curPos)
        {
            jumps++;
            curPos = maxReachable;
        }
        maxReachable = std::max(maxReachable, i + nums[i]);
    }

    return jumps;
}
