#include "problem_2841.h"

#include <unordered_map>

bool problem_2841::test() {
    std::vector nums { 2, 6, 7, 3, 1, 7 };
    int m = 3;
    int k = 4;

    int expected = 18;

    auto result = maxSum(nums, m, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2841::maxSum(std::vector<int> &nums, int m, int k) {
    int n = nums.size();
    std::unordered_map<int, int> counts;
    long long cur = 0;
    for (int i = 0; i < k; ++i)
    {
        if (!counts.contains(nums[i]))
            counts[nums[i]] = 1;
        else
            counts[nums[i]]++;
        cur += nums[i];
    }
    long long result = counts.size() >= m ? cur : 0;
    for (int i = k; i < n; ++i)
    {
        cur += nums[i] - nums[i - k];
        if (!counts.contains(nums[i]))
            counts[nums[i]] = 1;
        else
            counts[nums[i]]++;
        counts[nums[i - k]]--;
        if (counts[nums[i - k]] == 0)
            counts.erase(nums[i - k]);
        if (counts.size() >= m)
            result = std::max(result, cur);
    }

    return result;
}
