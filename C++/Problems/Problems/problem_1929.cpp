#include "problem_1929.h"

bool problem_1929::test() {
    std::vector nums { 1, 3, 2, 1 };

    std::vector expected { 1, 3, 2, 1, 1, 3, 2, 1 };

    auto result = getConcatenation(nums);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_1929::getConcatenation(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result(2 * n);
    for (int i = 0; i < n; i++)
    {
        result[i] = nums[i];
        result[n + i] = nums[i];
    }

    return result;
}
