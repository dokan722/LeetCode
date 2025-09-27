#include "problem_2656.h"

bool problem_2656::test() {
    std::vector nums { 1, 2, 3, 4, 5 };
    int k = 3;

    int expected = 18;

    auto result = maximizeSum(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2656::maximizeSum(std::vector<int> &nums, int k) {
    int n = nums.size();
    int biggest = nums[0];
    for (int i = 1; i < n; ++i)
        biggest = std::max(biggest, nums[i]);
    return biggest * k + ((k - 1) * k / 2);
}
