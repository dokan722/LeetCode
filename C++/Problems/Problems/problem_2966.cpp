#include "problem_2966.h"

#include <algorithm>

bool problem_2966::test() {
    std::vector nums  {1, 3, 4, 8, 7, 9, 3, 5, 1};

    auto k = 2;

    std::vector<std::vector<int>> expected {  { 1, 1, 3 },  { 3, 4, 5 }, { 7, 8, 9 } };

    auto result = divideArray(nums, k);

    if (result.size() != expected.size())
        return false;

    for (int i = 0; i < result.size(); i++) {
        if (result[i] != expected[i])
            return false;
    }

    return true;
}

std::vector<std::vector<int>> problem_2966::divideArray(std::vector<int> &nums, int k) {
    std::sort(nums.begin(), nums.end());
    std::vector<std::vector<int>> results;

    for (int i = 0; i < nums.size(); i += 3)
    {
        if (std::abs(nums[i] - nums[i + 2]) > k)
            return {};
        results.push_back( { nums[i], nums[i + 1], nums[i + 2] });
    }

    return results;
}
