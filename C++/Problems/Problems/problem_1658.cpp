#include "problem_1658.h"

bool problem_1658::test() {
    std::vector nums { 1, 1, 4, 2, 3 };
    int x = 5;

    int expceted = 2;

    auto result = minOperations(nums, x);

    std::cout << result << std::endl;

    return result == expceted;
}

int problem_1658::minOperations(std::vector<int> &nums, int x) {
    int n = nums.size();
    int total = 0;
    for (auto num : nums)
        total += num;
    if (total < x)
        return -1;
    if (total == x)
        return n;
    int result = INT_MAX;
    int r = 0;
    int cur = 0;
    int req = total - x;
    for (int i = 0; i < n; ++i)
    {
        while (r < n && cur < req)
            cur += nums[r++];
        if (cur == req)
            result = std::min(result, n - (r - i));
        if (cur < req)
            break;
        cur -= nums[i];
    }

    return result == INT_MAX ? -1 : result;
}
