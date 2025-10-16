#include "problem_2598.h"

bool problem_2598::test() {
    std::vector nums { 1, -10, 7, 13, 6, 8 };
    int value = 5;

    int expected = 4;

    auto result = findSmallestInteger(nums, value);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2598::findSmallestInteger(std::vector<int> &nums, int value) {
    int n = nums.size();
    std::vector counts(value, 0);

    for (int i = 0; i < n; i++)
        counts[(nums[i] % value + value) % value]++;

    int minCount = INT_MAX;
    int minValue = INT_MAX;
    for (int i = 0; i < value; ++i)
    {
        if (counts[i] < minCount)
        {
            minCount = counts[i];
            minValue = i;
        }
    }

    return value * minCount + minValue;
}
