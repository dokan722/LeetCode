#include "problem_3659.h"

#include <unordered_map>

bool problem_3659::test() {
    std::vector nums { 1, 2, 3, 4 };
    int k = 2;

    bool expected = true;

    auto result = partitionArray(nums, k);

    return result == expected;
}

bool problem_3659::partitionArray(std::vector<int> &nums, int k) {
    int n = nums.size();
    if (n % k != 0)
        return false;
    int groups = n / k;
    std::unordered_map<int, int> counts;
    for (auto num : nums)
    {
        if (counts.contains(num))
            counts[num]++;
        else
            counts[num] = 1;
        if (counts[num] > groups)
            return false;
    }

    return true;
}
