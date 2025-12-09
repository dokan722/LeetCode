#include "problem_442.h"

bool problem_442::test() {
    std::vector nums { 4, 3, 2, 7, 8, 2, 3, 1 };

    std::vector expected { 2, 3 };

    auto result = findDuplicates(nums);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_442::findDuplicates(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result;
    for (int i = 0; i < n; i++)
    {
        int id = std::abs(nums[i]) - 1;
        if (nums[id] < 0)
            result.push_back(std::abs(nums[i]));
        else
            nums[id] = -nums[id];
    }

    return result;
}
