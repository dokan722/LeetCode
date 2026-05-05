#include "problem_3254.h"

bool problem_3254::test() {
    std::vector nums { 1, 2, 3, 4, 3, 2, 5 };
    int k = 3;

    std::vector expected { 3, 4, -1, -1, -1 };

    auto result = resultsArray(nums, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3254::resultsArray(std::vector<int> &nums, int k) {
    int n = nums.size();
    if (k == 1)
        return nums;
    std::vector<int> result(n - k + 1);
    int cur = 1;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] == nums[i - 1] + 1)
            cur++;
        else
            cur = 1;
        if (i >= k - 1)
        {
            if (cur >= k)
                result[i - k + 1] = nums[i];
            else
                result[i - k + 1] = -1;
        }
    }

    return result;
}
