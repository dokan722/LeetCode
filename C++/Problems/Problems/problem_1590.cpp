#include "problem_1590.h"

#include <unordered_map>

bool problem_1590::test() {
    std::vector nums { 1, 2, 3 };
    int p = 7;

    int expected = -1;

    auto result = minSubarray(nums, p);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1590::minSubarray(std::vector<int> &nums, int p) {
    int n = nums.size();
    int rest = 0;
    for (int i = 0; i < n; ++i)
    {
        rest = (rest + nums[i]) % p;
    }

    if (rest == 0)
        return 0;

    std::unordered_map<int, int> prev;
    prev[0] = -1;
    int result = INT_MAX;
    int curr = 0;
    for (int i = 0; i < n; ++i)
    {
        curr = (curr + nums[i]) % p;
        int req = (curr - rest + p) % p;
        if (prev.contains(req))
            result = std::min(result, i - prev[req]);
        prev[curr] = i;
    }

    return result >= n ? -1 : result;
}
