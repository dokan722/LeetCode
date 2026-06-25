#include "problem_3942.h"

bool problem_3942::test() {
    std::vector nums { 0, 2, 1 };

    int expected = 2;

    auto result = minOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3942::minOperations(std::vector<int> &nums) {
    int n = nums.size();
    if (n == 1)
        return 0;
    int zero = 0;
    for (int i = 1; i < n; ++i)
    {
        int diff = std::abs(nums[i] - nums[i - 1]);
        if (diff != 1 && diff != n - 1)
            return -1;
        if (nums[i] == 0)
            zero = i;
    }
    if (nums[(zero + 1) % n] - nums[zero] == 1)
    {
        return std::min(zero, n - 1 - zero + 3);
    }
    return std::min(n - 1 - zero + 1, zero + 2);
}
