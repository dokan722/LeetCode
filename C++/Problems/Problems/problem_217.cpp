#include "problem_217.h"

#include <unordered_set>

bool problem_217::test() {
    std::vector nums { 1, 2, 3, 1 };

    bool expected = true;

    auto result = containsDuplicate(nums);

    std::cout << result << std::endl;

    return expected == result;
}

bool problem_217::containsDuplicate(std::vector<int> &nums) {
    std::unordered_set<int> s;
    for (auto n : nums)
    {
        if (s.contains(n))
            return true;
        s.insert(n);
    }
    return false;
}
