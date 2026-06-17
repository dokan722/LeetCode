#include "problem_3904.h"

bool problem_3904::test() {
    std::vector nums  { 5, 0, 1, 4 };
    int k = 3;

    int expected = 3;

    auto result = firstStableIndex(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3904::firstStableIndex(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector<int> mins(n);
    mins[n - 1] = nums[n - 1];
    for (int i = n - 2; i >= 0; --i)
    {
        mins[i] = std::min(nums[i], mins[i + 1]);
    }

    int mx = -1;
    for (int i = 0; i < n; ++i)
    {
        mx = std::max(mx, nums[i]);
        if (mx - mins[i] <= k)
            return i;
    }

    return -1;
}
