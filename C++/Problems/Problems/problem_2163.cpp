#include "problem_2163.h"

#include <queue>

bool problem_2163::test() {
    std::vector nums { 7, 9, 5, 8, 1, 3 };

    auto expected = 1;
    auto result = minimumDifference(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2163::minimumDifference(std::vector<int> &nums) {
    int l = nums.size();
    int n = nums.size() / 3;
    std::priority_queue<int> first;
    std::priority_queue<int, std::vector<int>, std::greater<>> second;
    long long sumFirst = 0L;
    long long sumSecond = 0L;
    for (int i = 0; i < n; i++)
    {
        first.push(nums[i]);
        second.push(nums[l - i - 1]);
        sumFirst += nums[i];
        sumSecond += nums[l - i - 1];
    }
    std::vector<long long> mins(n + 1, 0);
    mins[0] = sumFirst;
    for (int i = 0; i < n; i++)
    {
        first.push(nums[n + i]);
        auto removed = first.top();
        first.pop();
        mins[i + 1] = mins[i] - removed + nums[n + i];
    }

    auto result = mins[n] - sumSecond;
    for (int i = 1; i <= n; i++)
    {
        second.push(nums[2 * n - i]);
        auto removed = second.top();
        second.pop();
        sumSecond = sumSecond  - removed + nums[2 * n - i];
        auto diff = mins[n - i] - sumSecond;
        if (diff < result)
            result = diff;
    }

    return result;
}
