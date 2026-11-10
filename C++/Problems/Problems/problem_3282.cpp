#include "problem_3282.h"

bool problem_3282::test() {
    std::vector nums { 1, 3, 1, 5 };

    int expected = 7;

    auto result = findMaximumScore(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3282::findMaximumScore(std::vector<int> &nums) {
    int n = nums.size();
    long long result = 0;
    int cur = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] > nums[cur])
        {
            result += (long long)nums[cur] * (i - cur);
            cur = i;
        }
    }
    result += (long long)nums[cur] * (n - 1 - cur);

    return result;
}
