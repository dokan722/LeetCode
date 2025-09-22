#include "problem_2779.h"

bool problem_2779::test() {
    std::vector nums { 4, 6, 1, 2 };
    int k = 2;

    int expected = 3;

    auto result = maximumBeauty(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2779::maximumBeauty(std::vector<int> &nums, int k) {
    int maxValue = 0;
    for (auto num : nums)
    {
        maxValue = std::max(maxValue, num);
    }
    int range = maxValue + 2 * (k + 1);
    std::vector<int> intervals(range);

    for (auto num : nums)
    {
        intervals[num]++;
        intervals[num + 2 * k + 1]--;
    }

    int inside = 0;
    int result = 0;

    for (int i = 0; i < range; i++)
    {
        if (intervals[i] != 0)
        {
            inside += intervals[i];
            result = std::max(result, inside);
        }
    }

    return result;
}
