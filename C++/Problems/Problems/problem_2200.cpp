#include "problem_2200.h"

bool problem_2200::test() {
    std::vector nums { 3, 4, 9, 1, 3, 9, 5 };

    auto key = 9;
    auto k = 1;

    std::vector expected { 1, 2, 3, 4, 5, 6 };

    auto result = findKDistantIndices(nums, key, k);

    return expected == result;
}

std::vector<int> problem_2200::findKDistantIndices(std::vector<int> &nums, int key, int k) {
    auto right = 0;
    std::vector<int> result;

    for (int i = 0; i < nums.size(); i++)
    {
        if (nums[i] == key)
        {
            auto left = std::max(right, i - k);
            right = std::min((int)nums.size(), i + k + 1);
            for (int j = left; j < right; j++)
                result.push_back(j);
        }
    }

    return result;
}
