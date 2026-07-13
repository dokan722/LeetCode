#include "problem_3702.h"

bool problem_3702::test() {
    std::vector nums { 1, 2, 3 };

    int expected = 2;

    auto result = longestSubsequence(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3702::longestSubsequence(std::vector<int> &nums) {
    int n = nums.size();
    int x = 0;
    bool nonZero = false;
    for (auto num : nums)
    {
        x ^= num;
        if (num != 0)
            nonZero = true;
    }
    if (x != 0)
        return n;
    if (nonZero)
        return n - 1;
    return 0;
}
