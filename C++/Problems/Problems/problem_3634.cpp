#include "problem_3634.h"

#include <algorithm>

bool problem_3634::test() {
    std::vector nums  { 1, 6, 2, 9 };
    int k = 3;

    int expected = 2;

    auto result = minRemoval(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3634::minRemoval(std::vector<int> &nums, int k) {
    int n = nums.size();
    int result = 0;
    std::sort(nums.begin(), nums.end());
    int r = 0;
    for (int i = 0; i < n; ++i)
    {
        while (r < n && (long)nums[i] * k >= nums[r])
            r++;
        result = std::max(r - i, result);
    }

    return n - result;
}
