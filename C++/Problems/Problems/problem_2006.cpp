#include "problem_2006.h"

bool problem_2006::test() {
    std::vector nums { 3, 2, 1, 5, 4 };
    int k = 2;

    int expected = 3;

    auto result = countKDifference(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2006::countKDifference(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector counts(100 + 2 * k + 1, 0);
    int result = 0;
    for (int i = 0; i < n; i++)
    {
        result += counts[nums[i]] + counts[nums[i] + 2 * k];
        counts[nums[i] + k]++;
    }
    return result;
}
