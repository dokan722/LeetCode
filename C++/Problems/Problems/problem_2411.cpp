#include "problem_2411.h"

bool problem_2411::test() {
    std::vector nums { 1, 0, 2, 1, 3 };

    std::vector expected { 3, 3, 2, 2, 1 };

    auto result = smallestSubarrays(nums);

    return result == expected;
}

std::vector<int> problem_2411::smallestSubarrays(std::vector<int> &nums) {
    int n = nums.size();
    std::vector lastChange(32, -1);
    std::vector<int> result(n);
    for (int i = n - 1; i >= 0; --i)
    {
        int last = i;
        auto bits = intToBit(nums[i]);
        for (int j = 0; j < 32; ++j)
        {
            if (bits[j] == 0)
            {
                if (lastChange[j] != -1)
                {
                    last = std::max(last, lastChange[j]);
                }
            }
            else
            {
                lastChange[j] = i;
            }
        }
        result[i] = last - i + 1;
    }
    return result;
}

std::vector<int> problem_2411::intToBit(int value) {
    std::vector<int> bits(32);

    for (int i = 0; i < 32; i++)
    {
        bits[31 - i] = (value >> i) & 1;
    }

    return bits;
}
