#include "problem_1470.h"

bool problem_1470::test() {
    std::vector nums { 2, 5, 1, 3, 4, 7 };
    int n = 3;

    std::vector expected { 2, 3, 5, 4, 1, 7 };

    auto result = shuffle(nums, n);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1470::shuffle(std::vector<int> &nums, int n) {
    std::vector<int> result(2 * n);
    for (int i = 0; i < n; ++i)
    {
        result[2 * i] = nums[i];
        result[2 * i + 1] = nums[n + i];
    }

    return result;
}
