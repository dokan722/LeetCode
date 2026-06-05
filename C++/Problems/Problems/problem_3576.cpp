#include "problem_3576.h"

bool problem_3576::test() {
    std::vector nums  { 1, -1, 1, -1, 1 };
    int k = 3;

    bool expected = true;

    auto result = canMakeEqual(nums, k);

    return result == expected;
}

bool problem_3576::canMakeEqual(std::vector<int> &nums, int k) {
    int n = nums.size();
    int opsNeg = 0;
    int opsPos = 0;
    int nextNeg = nums[0];
    int nextPos = nums[0];
    for (int i = 0; i < n - 1; ++i)
    {
        if (nextPos == -1)
        {
            nextPos = nums[i + 1] * -1;
            opsPos++;
        }
        else
            nextPos = nums[i + 1];
        if (nextNeg == 1)
        {
            nextNeg = nums[i + 1] * -1;
            opsNeg++;
        }
        else
            nextNeg = nums[i + 1];
        if (opsPos > k && opsNeg > k)
            return false;
    }

    return (opsPos <= k && nextPos == 1) || (opsNeg <= k && nextNeg == -1);
}
