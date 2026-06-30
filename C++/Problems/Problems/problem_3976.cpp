#include "problem_3976.h"

bool problem_3976::test() {
    std::vector nums { 1, -2, 3, 4, -5 };
    int k = 2;

    int expected = 14;

    auto result = maxSubarraySum(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3976::maxSubarraySum(std::vector<int> &nums, int k) {
    long long curBase = 0;
    long long curMult = 0;
    long long curDiv = 0;
    long long curAfter = 0;
    long long result = INT_MIN;
    for (auto num : nums)
    {
        long long mult = (long long)num * k;
        long long div = (long long)num / k;
        curAfter = std::max(std::max(curMult + num, curDiv + num), curAfter + num);
        curMult = std::max(std::max(curBase + mult, curMult + mult), mult);
        curDiv = std::max(std::max(curBase + div, curDiv + div), div);
        curBase = std::max(curBase + num, (long long)num);
        result = std::max(result, std::max(std::max(curBase, curAfter), std::max(curDiv, curMult)));
    }
    return result;
}
