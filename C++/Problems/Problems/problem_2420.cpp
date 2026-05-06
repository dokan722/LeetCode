#include "problem_2420.h"

bool problem_2420::test() {
    std::vector nums  { 2, 1, 1, 1, 3, 4, 1 };
    int k = 2;

    std::vector expected  { 2, 3 };

    auto result = goodIndices(nums, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2420::goodIndices(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector to(n, 0);
    int cur = 1;
    for (int i = n - 2; i >= 0; --i)
    {
        to[i] = cur;
        if (nums[i] <= nums[i + 1])
            cur++;
        else
            cur = 1;
    }
    std::vector<int> result;
    cur = 1;
    for (int i = 1; i < n; ++i)
    {
        if (to[i] >= k && cur >= k)
            result.push_back(i);
        if (nums[i - 1] >= nums[i])
            cur++;
        else
            cur = 1;
    }

    return result;
}
