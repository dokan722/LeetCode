#include "problem_930.h"

#include <unordered_map>

bool problem_930::test() {
    std::vector nums { 1, 0, 1, 0, 1 };
    int goal = 2;

    int expected = 4;

    auto result = numSubarraysWithSum(nums, goal);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_930::numSubarraysWithSum(std::vector<int> &nums, int goal) {
    std::unordered_map<int, int> counts;
    int cur = 0;
    int result = 0;
    for (auto num : nums)
    {
        if (counts.contains(cur))
            counts[cur]++;
        else
            counts[cur] = 1;
        cur += num;
        int req = cur - goal;
        if (counts.contains(req))
            result += counts[req];
    }

    return result;
}
