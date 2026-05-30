#include "problem_1785.h"

bool problem_1785::test() {
    std::vector nums  { 1, -1, 1 };
    int limit = 3;
    int goal = -4;

    int expected = 2;

    auto result = minElements(nums, limit, goal);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1785::minElements(std::vector<int> &nums, int limit, int goal) {
    long long s = 0;
    for (auto num : nums)
        s += num;
    return (int)((std::abs(goal - s) + std::abs(limit) - 1) / limit);
}
