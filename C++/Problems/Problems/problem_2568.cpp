#include "problem_2568.h"

#include <unordered_set>

bool problem_2568::test() {
    std::vector nums { 2, 1 };

    int expected = 4;

    auto result = minImpossibleOR(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2568::minImpossibleOR(std::vector<int> &nums) {
    std::unordered_set<int> s;
    for (auto num : nums)
        s.insert(num);
    int result = 1;
    while (s.contains(result))
        result *= 2;
    return result;
}
