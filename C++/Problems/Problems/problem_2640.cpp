#include "problem_2640.h"

bool problem_2640::test() {
    std::vector nums { 2, 3, 7, 5, 10 };

    std::vector<long long> expected { 4, 10, 24, 36, 56 };

    auto result = findPrefixScore(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<long long> problem_2640::findPrefixScore(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<long long> result(n);
    int max = nums[0];
    result[0] = 2 * max;
    for (int i = 1; i < n; i++)
    {
        max = std::max(max, nums[i]);
        result[i] = result[i - 1] + nums[i] + max;
    }

    return result;
}
