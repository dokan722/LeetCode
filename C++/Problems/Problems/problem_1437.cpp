#include "problem_1437.h"

bool problem_1437::test() {
    std::vector nums { 1, 0, 0, 0, 1, 0, 0, 1 };
    int k = 2;

    bool expected = true;

    auto result = kLengthApart(nums, k);

    return result == expected;
}

bool problem_1437::kLengthApart(std::vector<int> &nums, int k) {
    int n = nums.size();
    int last = -1000000;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] == 1)
        {
            if (i - last - 1 < k)
                return false;
            last = i;
        }
    }

    return true;
}
