#include "problem_961.h"

#include <unordered_set>

bool problem_961::test() {
    std::vector nums { 1, 2, 3, 3 };

    int expected = 3;

    auto result = repeatedNTimes(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_961::repeatedNTimes(std::vector<int> &nums) {
    std::unordered_set<int> set;
    for (auto num : nums)
    {
        if (set.contains(num))
            return num;
        set.insert(num);
    }

    return 0;
}
