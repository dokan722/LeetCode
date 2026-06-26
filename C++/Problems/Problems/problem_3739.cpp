#include "problem_3739.h"

bool problem_3739::test() {
    std::vector nums { 1, 2, 2, 3 };
    int target = 2;

    int expected = 5;

    auto result = countMajoritySubarrays(nums, target);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3739::countMajoritySubarrays(std::vector<int> &nums, int target) {
    int n = nums.size();
    std::vector counts(2 * n + 2, 0);
    std::vector pref(2 * n + 2, 0);
    int cur = n + 1;
    pref[cur] = 1;
    counts[cur] = 1;
    long result = 0;
    for (int i = 0; i < n; ++i)
    {
        cur += (nums[i] == target ? 1 : -1);
        counts[cur]++;
        pref[cur] = pref[cur - 1] + counts[cur];
        result += pref[cur - 1];
    }

    return result;
}
