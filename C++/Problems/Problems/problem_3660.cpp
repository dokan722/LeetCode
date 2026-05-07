#include "problem_3660.h"

bool problem_3660::test() {
    std::vector nums  { 2, 1, 3 };

    std::vector expected  { 2, 2, 3 };

    auto result = maxValue(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3660::maxValue(std::vector<int> &nums) {
    int n = nums.size();
    int mx = 0;
    std::vector<int> leftMax(n);
    for (int i = 0; i < n; ++i)
    {
        mx = std::max(nums[i], mx);
        leftMax[i] = mx;
    }

    std::vector<int> result(n);
    result[n - 1] = leftMax[n - 1];
    int mn = nums[n - 1];
    for (int i = n - 2; i >= 0; --i)
    {
        if (mn < leftMax[i])
            result[i] = result[i + 1];
        else
            result[i] = leftMax[i];
        mn = std::min(mn, nums[i]);
    }

    return result;
}
