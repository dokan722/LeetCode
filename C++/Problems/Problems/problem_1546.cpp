#include "problem_1546.h"

#include <unordered_set>

bool problem_1546::test() {
    std::vector nums { 1, 1, 1, 1, 1 };
    int target = 2;

    int expected = 2;

    auto result = maxNonOverlapping(nums, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1546::maxNonOverlapping(std::vector<int> &nums, int target) {
    std::unordered_set<int> present;
    present.insert(0);
    int cur = 0;
    int result = 0;
    for (auto num : nums)
    {
        cur += num;
        int req = cur - target;
        if (present.contains(req))
        {
            result++;
            present.clear();
            cur = 0;
        }
        present.insert(cur);
    }

    return result;
}
