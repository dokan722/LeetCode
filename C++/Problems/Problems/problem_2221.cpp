#include "problem_2221.h"

bool problem_2221::test() {
    std::vector nums { 1, 2, 3, 4, 5 };

    int expected = 8;

    auto result = triangularSum(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2221::triangularSum(std::vector<int> &nums) {
    int n = nums.size();
    for (int i = 1; i < n; ++i)
    {
        for (int j = 0; j < n - i; ++j)
            nums[j] = (nums[j] + nums[j + 1]) % 10;
    }

    return nums[0];
}
