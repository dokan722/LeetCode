#include "problem_2154.h"

#include <unordered_set>

bool problem_2154::test() {
    std::vector nums { 5, 3, 6, 1, 12 };
    int original = 3;

    int expected = 24;

    auto result = findFinalValue(nums, original);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2154::findFinalValue(std::vector<int> &nums, int original) {
    std::unordered_set<int> numsSet(nums.begin(), nums.end());
    while (numsSet.contains(original))
    {
        original <<= 1;
    }

    return original;
}
