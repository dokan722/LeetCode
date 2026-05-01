#include "problem_560.h"

#include <unordered_map>

bool problem_560::test() {
    std::vector nums  { 1, 1, 1 };
    int k = 2;

    int expected = 2;

    auto result = subarraySum(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_560::subarraySum(std::vector<int> &nums, int k) {
    std::unordered_map<int, int> prev;
    prev[0] = 1;
    int cur = 0;
    int result = 0;
    for (auto num : nums)
    {
        cur += num;
        int req = cur - k;
        if (prev.contains(req))
            result += prev[req];
        if (prev.contains(cur))
            prev[cur]++;
        else
            prev[cur] = 1;
    }

    return result;
}
