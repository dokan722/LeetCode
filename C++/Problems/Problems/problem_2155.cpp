#include "problem_2155.h"

bool problem_2155::test() {
    std::vector nums  { 0, 0, 1, 0 };

    std::vector expected  { 4, 2 };

    auto result = maxScoreIndices(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2155::maxScoreIndices(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> zeros(n);
    int cur = 0;
    for (int i = 0; i < n; ++i)
    {
        zeros[i] = cur;
        if (nums[i] == 0)
            cur++;
    }
    std::vector result { n };
    int mx = cur;
    cur = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        if (nums[i] == 1)
            cur++;
        int val = cur + zeros[i];
        if (val > mx)
        {
            mx = val;
            result.clear();
            result.push_back(i);
        }
        else if (val == mx)
            result.push_back(i);
    }

    return result;
}
