#include "problem_628.h"

bool problem_628::test() {
    std::vector nums { 1, 2, 3 };

    int expected = 6;

    auto result = maximumProduct(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_628::maximumProduct(std::vector<int> &nums) {
    int max1 = INT_MIN;
    int max2 = INT_MIN;
    int max3 = INT_MIN;
    int min1 = INT_MAX;
    int min2 = INT_MAX;
    for (auto n : nums)
    {
        if (n >= max1)
        {
            max3 = max2;
            max2 = max1;
            max1 = n;
        }
        else if (n >= max2)
        {
            max3 = max2;
            max2 = n;
        }
        else if (n > max3)
            max3 = n;

        if (n <= min1)
        {
            min2 = min1;
            min1 = n;
        }
        else if (n < min2)
            min2 = n;
    }
    return std::max(min1 * min2 * max1, max1 * max2 * max3);
}
