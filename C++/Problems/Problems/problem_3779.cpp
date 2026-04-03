#include "problem_3779.h"

#include <unordered_set>

bool problem_3779::test() {
    std::vector nums { 3, 8, 3, 6, 5, 8 };

    int expected = 1;

    auto result = minOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3779::minOperations(std::vector<int> &nums) {
    int n = nums.size();
    std::unordered_set<int> present;
    for (int i = n - 1; i >= 0; --i)
    {
        if (present.contains(nums[i]))
            return (i + 1 + 2) / 3;
        present.insert(nums[i]);
    }

    return 0;
}
