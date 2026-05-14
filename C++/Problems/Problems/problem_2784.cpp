#include "problem_2784.h"

bool problem_2784::test() {
    std::vector nums { 2, 1, 3 };

    bool expected = false;

    auto result = isGood(nums);

    std::cout << result << std::endl;

    return result == expected;
}

bool problem_2784::isGood(std::vector<int> &nums) {
    int n = nums.size();
    std::vector present(201, false);
    int count = 0;
    for (auto num : nums)
    {
        if (present[num] && num != n - 1 || num > n - 1)
            return false;
        present[num] = true;
        if (num != n - 1)
            count++;
    }

    return count == n - 2 && present[n - 1];
}
