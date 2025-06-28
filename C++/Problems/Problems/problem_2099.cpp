#include "problem_2099.h"

#include <algorithm>
#include <string>

bool problem_2099::test() {
    std::vector nums { 2, 1, 3, 3 };
    auto k = 2;

    std::vector expected { 3, 3 };

    auto result = maxSubsequence(nums, k);


    return result == expected;
}

std::vector<int> problem_2099::maxSubsequence(std::vector<int> &nums, int k) {
    std::vector<std::vector<int>> indexed;
    for (int i = 0; i < nums.size(); i++)
        indexed.push_back(std::vector {i, nums[i]});
    std::sort(indexed.begin(), indexed.end(), [&](auto &a, auto &b) { return a[1] > b[1]; });
    std::sort(indexed.begin(), indexed.begin() + k);
    std::vector<int> result;
    for (int i = 0; i < k; i++)
        result.push_back(indexed[i][1]);
    return result;
}
