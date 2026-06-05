#include "problem_3847.h"

bool problem_3847::test() {
    std::vector nums  { 1, 2, 3 };

    int expected = 0;

    auto result = scoreDifference(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3847::scoreDifference(std::vector<int> &nums) {
    int n = nums.size();
    int det = 1;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] % 2 == 1)
            det *= -1;
        if (i % 6 == 5)
            det *= -1;
        result += nums[i] * det;
    }

    return result;
}
