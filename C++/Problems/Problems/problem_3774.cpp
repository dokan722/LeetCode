#include "problem_3774.h"

#include <algorithm>

bool problem_3774::test() {
    std::vector nums { 5, 2, 2, 4 };
    int k = 2;

    int expected = 5;

    auto result = absDifference(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3774::absDifference(std::vector<int> &nums, int k) {
    int n = nums.size();
    int result = 0;
    std::sort(nums.begin(), nums.end());
    for (int i = 0; i < k; ++i)
    {
        result -= nums[i];
        result += nums[n - i - 1];
    }

    return result;
}
