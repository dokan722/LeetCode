#include "problem_3471.h"

bool problem_3471::test() {
    std::vector nums { 3, 9, 2, 1, 7 };
    int k = 3;

    int expected = 7;

    auto result = largestInteger(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3471::largestInteger(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector counts(51, 0);
    for (auto num : nums)
        counts[num]++;
    if (k == 1)
    {
        for (int i = 50; i >= 0; --i)
            if (counts[i] == 1)
                return i;
    }
    else if (k == n)
    {
        for (int i = 50; i >= 0; --i)
            if (counts[i] != 0)
                return i;
    }
    else
    {
        for (int i = 50; i >= 0; --i)
            if (counts[i] == 1 && (i == nums[0] || i == nums[n - 1]))
                return i;
    }
    return -1;
}
