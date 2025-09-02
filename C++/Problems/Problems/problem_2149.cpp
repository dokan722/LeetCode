#include "problem_2149.h"

bool problem_2149::test() {
    std::vector nums { 3, 1, -2, -5, 2, -4 };

    std::vector expected = { 3, -2, 1, -5, 2, -4 };

    auto result = rearrangeArray(nums);

    return result == expected;
}

std::vector<int> problem_2149::rearrangeArray(std::vector<int> &nums) {
    int n = nums.size();
    std::vector<int> result(n);
    int neg = 1;
    int pos = 0;
    for (int i = 0; i < n; i++)
    {
        if (nums[i] < 0)
        {
            result[neg] = nums[i];
            neg += 2;
        }
        else
        {
            result[pos] = nums[i];
            pos += 2;
        }
    }

    return result;
}
