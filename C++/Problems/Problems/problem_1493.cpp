#include "problem_1493.h"

bool problem_1493::test() {
    std::vector nums { 0, 1, 1, 1, 0, 1, 1, 0, 1 };
    auto expected = 5;

    auto result = longestSubarray(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1493::longestSubarray(std::vector<int> &nums) {
    auto result = 0;
    auto j = 0;
    auto zeros = 0;
    auto ones = 0;
    for (int i = 0; i < nums.size(); i++)
    {
        if (nums[i] == 0)
            zeros++;
        else
            ones++;
        while (j < i && zeros > 1)
        {
            if (nums[j] == 0)
                zeros--;
            else
                ones--;
            j++;
        }

        auto sub = zeros == 0 ? 1 : 0;
        if (ones - sub > result)
            result = ones - sub;
    }

    return result;
}
