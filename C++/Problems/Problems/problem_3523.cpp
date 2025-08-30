#include "problem_3523.h"

bool problem_3523::test() {
    std::vector nums {4, 2, 5, 3, 5};

    int expected = 3;

    auto result = maximumPossibleSize(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3523::maximumPossibleSize(std::vector<int> &nums) {
    int n = nums.size();
    int reduced = 0;
    for (int i = 1; i < n; i++)
    {
        if (nums[i] > nums[i - 1])
            continue;
        int j = i;
        while (j < n && nums[j] < nums[i - 1])
            j++;
        reduced += j - i;
        i = j;
    }

    return n - reduced;
}
