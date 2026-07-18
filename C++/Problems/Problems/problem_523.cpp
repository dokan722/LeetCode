#include "problem_523.h"

#include <unordered_set>

bool problem_523::test() {
    std::vector nums { 23, 2, 4, 6, 7 };
    int k = 6;

    bool expected = true;

    auto result = checkSubarraySum(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

bool problem_523::checkSubarraySum(std::vector<int> &nums, int k) {
    int n = nums.size();
    if (n > 2L * k)
        return true;
    int cur = nums[0];
    std::unordered_set<int> last;
    last.insert(0);
    for (int i = 1; i < n; ++i)
    {
        int next = cur + nums[i];
        int req = next % k;
        if (last.contains(req))
            return true;
        last.insert(cur % k);
        cur = next;
    }

    return false;
}

