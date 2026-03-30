#include "problem_3732.h"

bool problem_3732::test() {
    std::vector nums { -5, 7, 0 };

    long long expected = 3500000;

    auto result = maxProduct(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3732::maxProduct(std::vector<int> &nums) {
    int n = nums.size();
    std::vector mins  { INT_MAX, INT_MAX };
    std::vector maxs  { INT_MIN, INT_MIN };
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] > maxs[0])
        {
            maxs[1] = maxs[0];
            maxs[0] = nums[i];
        }
        else if (nums[i] > maxs[1])
            maxs[1] = nums[i];
        if (nums[i] < mins[0])
        {
            mins[1] = mins[0];
            mins[0] = nums[i];
        }
        else if (nums[i] < mins[1])
            mins[1] = nums[i];
    }
    long long best = std::max(std::max(std::abs((long long)mins[0] * mins[1]), std::abs((long long)maxs[0] * maxs[1])), std::abs((long long)maxs[0] * mins[0]));

    return best * 100000;
}
