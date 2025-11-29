#include "problem_3512.h"

bool problem_3512::test() {
    std::vector nums { 3, 9, 7 };
    int k = 5;

    int expected = 4;

    auto result = minOperations(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3512::minOperations(std::vector<int> &nums, int k) {
    int n = nums.size();
    int sum = 0;
    for (int i = 0; i < n; ++i)
    {
        sum += nums[i];
    }

    return sum % k;
}
