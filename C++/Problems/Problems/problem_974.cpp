#include "problem_974.h"

bool problem_974::test() {
    std::vector nums { 4, 5, 0, -2, -3, 1 };
    int k = 5;

    int expected = 7;

    auto result = subarraysDivByK(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_974::subarraysDivByK(std::vector<int> &nums, int k) {
    int n = nums.size();
    std::vector mods(k, 0);
    mods[0] = 1;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        sum += nums[i];
        int mod = (sum % k + k) % k;
        result += mods[mod];
        mods[mod]++;
    }

    return result;
}
