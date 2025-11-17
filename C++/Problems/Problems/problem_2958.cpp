#include "problem_2958.h"

#include <unordered_map>

bool problem_2958::test() {
    std::vector nums { 1, 2, 3, 1, 2, 3, 1, 2 };
    int k = 2;

    int expected = 6;

    auto result = maxSubarrayLength(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2958::maxSubarrayLength(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::unordered_map<int, int> counts;
    int j = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (counts.contains(nums[i]))
        {
            counts[nums[i]]++;
            if (counts[nums[i]] > k)
            {
                result = std::max(result, i - j);
                while (counts[nums[i]] > k)
                {
                    counts[nums[j]]--;
                    j++;
                }
            }
        }
        else
            counts[nums[i]] = 1;
    }

    result = std::max(result, n - j);

    return result;
}
