#include "problem_3741.h"

#include <unordered_map>

bool problem_3741::test() {
    std::vector nums { 1, 1, 2, 3, 2, 1, 2 };

    int expected = 8;

    auto result = minimumDistance(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3741::minimumDistance(std::vector<int> &nums) {
    int n = nums.size();
    std::unordered_map<int, std::pair<int, int>> pairs;
    int result = INT_MAX;
    for (int i = 0; i < n; i++)
    {
        if (!pairs.contains(nums[i]))
            pairs[nums[i]] = std::pair(i, i);
        else
        {
            auto pair = pairs[nums[i]];
            if (pair.first == pair.second)
                pairs[nums[i]] = std::pair(pair.first, i);
            else
            {
                result = std::min(result, 2 * (i - pair.first));
                pairs[nums[i]] = std::pair(pair.second, i);
            }
        }
    }

    return result == INT_MAX ? -1 : result;
}
