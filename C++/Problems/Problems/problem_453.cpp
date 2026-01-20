#include "problem_453.h"

bool problem_453::test() {
    std::vector nums { 1, 2, 3 };

    int expected = 3;

    auto result = minMoves(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_453::minMoves(std::vector<int> &nums) {
    int n = nums.size();
    int m = INT_MAX;
    int sum = 0;
    for (int i = 0; i < n; ++i)
    {
        sum += nums[i];
        m = std::min(m, nums[i]);
    }
    return sum - n * m;
}
