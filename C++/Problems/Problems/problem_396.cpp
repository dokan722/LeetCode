#include "problem_396.h"

bool problem_396::test() {
    std::vector nums { 4, 3, 2, 6 };

    int expected = 26;

    int result = maxRotateFunction(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_396::maxRotateFunction(std::vector<int> &nums) {
    int n = nums.size();
    int sum = 0;
    int fvalue = 0;
    for (int i = 0; i < n; ++i)
    {
        sum += nums[i];
        fvalue += nums[i] * i;
    }

    int result = fvalue;

    for (int i = 1; i < n; ++i)
    {
        fvalue += sum;
        fvalue -= nums[n - i] * n;
        result = std::max(result, fvalue);
    }

    return result;
}
