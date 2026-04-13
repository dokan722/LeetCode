#include "problem_1848.h"

bool problem_1848::test() {
    std::vector nums  { 1, 2, 3, 4, 5 };
    int target = 5;
    int start = 3;

    int expected = 1;

    auto result = getMinDistance(nums, target, start);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1848::getMinDistance(std::vector<int> &nums, int target, int start) {
    int n = nums.size();
    int result = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == target)
            result = std::min(result, std::abs(i - start));
    }

    return result;
}
