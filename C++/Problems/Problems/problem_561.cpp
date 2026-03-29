#include "problem_561.h"

bool problem_561::test() {
    std::vector nums { 1, 4, 3, 2 };

    int expected = 4;

    auto result = arrayPairSum(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_561::arrayPairSum(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    int result = 0;
    for (int i = 0; i < n; i += 2)
    {
        result += nums[i];
    }

    return result;
}
