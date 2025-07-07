#include "problem_3011.h"

bool problem_3011::test() {
    std::vector nums { 3, 16, 8, 4, 2 };

    auto expected = false;

    auto result = canSortArray(nums);

    return expected == result;
}

bool problem_3011::canSortArray(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> bits(n);
    for (int i = 0; i < n; ++i)
        bits[i] = countBits(nums[i]);
    for (int i = 0; i < n - 1; ++i)
    {
        for (int j = i + 1; j < n; ++j)
        {
            if (nums[j] < nums[i] && bits[i] != bits[j])
                return false;
        }
    }

    return true;
}

int problem_3011::countBits(int num) {
    int bits = 0;

    for (int i = 0; i <= 9; ++i)
    {
        bits += num & 1;
        num = (num >> 1);
    }

    return bits;
}
