#include "problem_2317.h"

bool problem_2317::test() {
    std::vector nums  { 3, 2, 4, 6 };

    int expected = 7;

    auto result = maximumXOR(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2317::maximumXOR(std::vector<int> &nums) {
    int result = 0;
    for (auto n : nums)
        result |= n;
    return result;
}
