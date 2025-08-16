#include "problem_2270.h"

bool problem_2270::test() {
    std::vector nums { 10, 4, -8, 7 };

    auto expected = 2;

    auto result = waysToSplitArray(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2270::waysToSplitArray(std::vector<int> &nums) {
    long long sumRight = 0;
    for (int num : nums)
        sumRight += num;
    long long sumLeft = 0;
    auto result = 0;
    for (int i = 0; i < nums.size() - 1; ++i)
    {
        sumRight -= nums[i];
        sumLeft += nums[i];
        if (sumLeft >= sumRight)
            result++;
    }

    return result;
}
