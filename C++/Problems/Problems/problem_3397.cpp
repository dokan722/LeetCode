#include "problem_3397.h"

#include <algorithm>

bool problem_3397::test() {
    std::vector nums { 1, 2, 2, 3, 3, 4 };
    int k = 2;

    int expected = 6;

    int result = maxDistinctElements(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3397::maxDistinctElements(std::vector<int> &nums, int k) {
    std::sort(nums.begin(), nums.end());
    int prev = INT_MIN;
    int result = 0;
    for (int num : nums)
    {
        int curr = std::min(std::max(num - k, prev + 1), num + k);
        if (curr > prev)
        {
            result++;
            prev = curr;
        }
    }
    return result;
}
