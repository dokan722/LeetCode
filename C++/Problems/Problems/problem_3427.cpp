#include "problem_3427.h"

bool problem_3427::test() {
    std::vector nums { 2, 3, 1 };

    int expected = 11;

    auto result = subarraySum(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3427::subarraySum(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> pref(n + 1);
    int result = 0;

    for (int i = 0; i < n; i++)
    {
        pref[i + 1] = nums[i] + pref[i];
        int start = std::max(0, i - nums[i]);
        result += pref[i + 1] - pref[start];
    }

    return result;
}
