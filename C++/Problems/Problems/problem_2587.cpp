#include "problem_2587.h"

bool problem_2587::test() {
    std::vector nums  { 2, -1, 0, 1, -3, 3, -3 };

    int expected = 6;

    auto result = maxScore(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2587::maxScore(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    long long pre = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        pre += nums[i];
        if (pre <= 0)
            return n - i - 1;
    }

    return n;
}
