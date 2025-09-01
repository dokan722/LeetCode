#include "problem_1877.h"

#include <algorithm>

bool problem_1877::test() {
    std::vector nums { 3, 5, 2, 3 };

    int expected = 7;

    auto result = minPairSum(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1877::minPairSum(std::vector<int> &nums) {
    std::ranges::sort(nums);
    int half = nums.size() / 2;
    int n = nums.size();
    int result = 0;
    for (int i = 0; i < half; ++i)
        result = std::max(result, nums[i] + nums[n - 1 - i]);

    return result;
}
