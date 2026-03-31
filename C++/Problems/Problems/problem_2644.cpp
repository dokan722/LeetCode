#include "problem_2644.h"

bool problem_2644::test() {
    std::vector nums  { 2, 9, 15, 50 };
    std::vector divisors { 5, 3, 7, 2 };

    int expected = 2;

    auto result = maxDivScore(nums, divisors);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2644::maxDivScore(std::vector<int> &nums, std::vector<int> &divisors) {
    int n = nums.size();
    int m = divisors.size();
    int result = divisors[0];
    int best = 0;
    for (int i = 0; i < m; ++i)
    {
        int cur = 0;
        for (int j = 0; j < n; ++j)
        {
            if (nums[j] % divisors[i] == 0)
                cur++;
        }
        if (cur > best || (cur == best && divisors[i] < result))
        {
            best = cur;
            result = divisors[i];
        }
    }

    return result;
}
