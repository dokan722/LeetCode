#include "problem_3727.h"

#include <algorithm>

bool problem_3727::test() {
    std::vector nums { 1, -1, 2, -2, 3, -3 };

    int expected = 16;

    auto result = maxAlternatingSum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3727::maxAlternatingSum(std::vector<int> &nums) {
    std::sort(nums.begin(), nums.end(), [](const int a, const int b) { return std::abs(a) < std::abs(b); });
    int half = nums.size() / 2;
    long score = 0;
    for (int i = 0; i < half; ++i)
        score -= nums[i] * nums[i];
    for (int i = half; i < nums.size(); ++i)
        score += nums[i] * nums[i];
    return score;
}
