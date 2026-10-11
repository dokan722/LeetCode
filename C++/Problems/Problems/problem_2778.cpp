#include "problem_2778.h"

bool problem_2778::test() {
    std::vector nums  { 1, 2, 3, 4 };

    int expected = 21;

    auto result = sumOfSquares(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2778::sumOfSquares(std::vector<int> &nums) {
    int n = nums.size();
    int result = 0;
    for (int i = 1; i <= n; ++i)
    {
        if (n % i == 0)
            result += nums[i - 1] * nums[i - 1];
    }

    return result;
}
