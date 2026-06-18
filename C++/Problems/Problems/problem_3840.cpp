#include "problem_3840.h"

bool problem_3840::test() {
    std::vector nums { 1, 4, 3, 5 };
    std::vector colors { 1, 1, 2, 2 };

    int expected = 9;

    auto result = rob(nums, colors);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_3840::rob(std::vector<int> &nums, std::vector<int> &colors) {
    int n = nums.size();
    long long result = 0;
    int prev = -1;
    std::vector<long long> dp {0 , 0};
    long long cur = 0;
    for (int i = 0; i < n; ++i)
    {
        if (prev != colors[i])
        {
            result += cur;
            dp[0] = 0;
            dp[1] = 0;
            prev = colors[i];
        }
        cur = std::max(nums[i] + dp[0], dp[1]);
        dp[0] = dp[1];
        dp[1] = cur;
    }
    result += cur;

    return result;
}
