#include "problem_462.h"

bool problem_462::test() {
    std::vector nums { 1, 2, 3 };

    int expected = 2;

    auto result = minMoves2(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_462::minMoves2(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    int med = nums[n / 2];
    int result = 0;
    for (int i = 0; i < n; ++i)
        result += std::abs(nums[i] - med);
    return result;
}
