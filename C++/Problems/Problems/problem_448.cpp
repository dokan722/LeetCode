#include "problem_448.h"

bool problem_448::test() {
    std::vector nums {4, 3, 2, 7, 8, 2, 3, 1};

    std::vector expected { 5, 6 };

    auto result = findDisappearedNumbers(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_448::findDisappearedNumbers(std::vector<int> &nums) {
    auto n = nums.size();

    for (int i = 0; i < n; ++i)
    {
        auto original = (nums[i] - 1) % n;
        if (nums[original] <= n)
            nums[original] += n;
    }

    std::vector<int> result;

    for (int i = 0; i < n; ++i)
    {
        if (nums[i] <= n)
            result.push_back(i + 1);
    }

    return result;
}
