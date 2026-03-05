#include "problem_2195.h"

bool problem_2195::test() {
    std::vector nums { 1, 4, 25, 10, 25 };
    int k = 2;

    int expected = 5;

    auto result = minimalKSum(nums, k);

    std::cout << result << std::endl;

    return expected == result;
}

long long problem_2195::minimalKSum(std::vector<int> &nums, int k) {
    int n = nums.size();
    long long currSum = (long long)k * (k + 1) / 2;
    std::sort(nums.begin(), nums.end());
    int th = k;
    int prev = -1;
    for (int i = 0; i < n; ++i)
    {
        if (nums[i] > th)
            break;
        else if (nums[i] != prev)
        {
            th++;
            currSum += th - nums[i];
            prev = nums[i];
        }
    }

    return currSum;
}
