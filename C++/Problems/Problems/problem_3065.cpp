#include "problem_3065.h"

bool problem_3065::test() {
    std::vector nums { 2, 11, 10, 1, 3 };
    int k = 10;

    int expected = 3;

    auto result = minOperations(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3065::minOperations(std::vector<int> &nums, int k) {
    int result = 0;
    for (auto n : nums)
        if (n < k)
            result++;
    return result;
}
