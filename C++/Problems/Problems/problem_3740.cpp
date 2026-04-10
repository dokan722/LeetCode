#include "problem_3740.h"

bool problem_3740::test() {
    std::vector nums { 1, 2, 1, 1, 3 };

    int expected = 6;

    auto result = minimumDistance(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3740::minimumDistance(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<std::vector<int>> prevs(n + 1, std::vector(2, -1));
    int result = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        if (prevs[nums[i]][0] != -1 && prevs[nums[i]][1] != -1)
            result = std::min(result, prevs[nums[i]][1] - prevs[nums[i]][0] + i - prevs[nums[i]][1] + i - prevs[nums[i]][0]);
        prevs[nums[i]][0] = prevs[nums[i]][1];
        prevs[nums[i]][1] = i;
    }

    return result == INT_MAX ? -1 : result;
}
