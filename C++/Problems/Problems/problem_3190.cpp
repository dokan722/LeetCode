#include "problem_3190.h"

bool problem_3190::test() {
    std::vector nums { 1, 2, 3, 4 };

    int expected = 3;

    auto result = minimumOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3190::minimumOperations(std::vector<int> &nums) {
    int result = 0;
    for (auto num : nums)
    {
        if (num % 3 != 0)
            result++;
    }

    return result;
}
