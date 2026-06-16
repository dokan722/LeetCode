#include "problem_2971.h"

bool problem_2971::test() {
    std::vector nums  { 5, 5, 5 };

    int expected = 15;

    auto result = largestPerimeter(nums);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2971::largestPerimeter(std::vector<int> &nums) {
    int n = nums.size();
    std::sort(nums.begin(), nums.end());
    long long  result = -1;
    long long pref = nums[0] + nums[1];
    for (int i = 2; i < n; ++i)
    {
        if (nums[i] < pref)
            result = nums[i] + pref;
        pref += nums[i];
    }
    return result;
}
