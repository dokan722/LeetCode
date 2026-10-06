#include "problem_3979.h"

bool problem_3979::test() {
    std::vector nums { 1, 3, 5, 2, 8 };
    int k = 2;

    int expected = 13;

    auto result = maxValidPairSum(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3979::maxValidPairSum(std::vector<int> &nums, int k) {
    int n = nums.size();
    int mx = nums[0];
    int result = 0;
    for (int i = 0; i < n - k; ++i)
    {
        mx = std::max(mx, nums[i]);
        result = std::max(result, mx + nums[i + k]);
    }

    return result;
}
