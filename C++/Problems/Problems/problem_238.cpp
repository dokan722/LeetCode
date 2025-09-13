#include "problem_238.h"

bool problem_238::test() {
    std::vector nums { 1, 2, 3, 4 };

    std::vector expected { 24, 12, 8, 6 };

    auto result = productExceptSelf(nums);

    return expected == result;
}

std::vector<int> problem_238::productExceptSelf(std::vector<int> &nums) {
    int n = nums.size();
    long product = 1;
    int zeroCount = 0;
    int zeroId = -1;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] != 0)
            product *= nums[i];
        else
        {
            zeroCount++;
            if (zeroCount > 1)
                return std::vector(n, 0);
            zeroId = i;
        }
    }

    if (zeroCount == 1)
    {
        std::vector result(n ,0);
        result[zeroId] = (int)product;
        return result;
    }

    for (int i = 0; i < n; ++i)
        nums[i] = (int)(product / (nums[i] != 0 ? nums[i] : 1));


    return nums;
}
