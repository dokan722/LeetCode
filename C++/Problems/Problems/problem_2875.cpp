#include "problem_2875.h"

bool problem_2875::test() {
    std::vector nums  { 5, 5, 4, 1, 2, 2, 2, 3, 2, 4, 2, 5 };
    int target = 56;

    int expected = 16;

    auto result = minSizeSubarray(nums, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2875::minSizeSubarray(std::vector<int> &nums, int target) {
    int n = nums.size();
    long s = 0;
    for (int i = 0; i < n; ++i)
        s += nums[i];
    int extra = (int)(target / s);
    int extraElems = n * extra;
    target -= (int)(extra * s);
    int r = 0;
    int result = INT_MAX;
    long cs = 0;
    for (int i = 0; i < n; ++i)
    {
        while (r < 2 * n && cs < target)
        {
            cs += nums[r % n];
            r++;
        }
        if (cs == target)
            result = std::min(result, extraElems + (r - i));
        cs -= nums[i];
    }
    return result == INT_MAX ? -1 : result;
}
