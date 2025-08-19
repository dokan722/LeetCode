#include "problem_2348.h"

bool problem_2348::test() {
    std::vector nums { 1, 3, 0, 0, 2, 0, 0, 4 };

    auto expected = 6;

    auto result = zeroFilledSubarray(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2348::zeroFilledSubarray(std::vector<int> &nums) {
    int n = nums.size();
    long long result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == 0)
        {
            auto begin = i;
            while (i < n && nums[i] == 0)
                i++;
            long long zeroCount = i - begin;
            result += zeroCount * (zeroCount + 1) / 2;
        }
    }

    return result;
}
