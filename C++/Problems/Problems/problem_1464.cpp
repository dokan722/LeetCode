#include "problem_1464.h"

bool problem_1464::test() {
    std::vector nums { 3, 4, 5, 2 };

    int expected = 12;

    auto result = maxProduct(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1464::maxProduct(std::vector<int> &nums) {
    int max1 = INT_MIN;
    int max2 = INT_MIN;
    for (auto num : nums)
    {
        if (max1 <= num)
        {
            max2 = max1;
            max1 = num;
        }
        else if (max2 <= num)
            max2 = num;
    }

    return (max1 - 1) * (max2 - 1);
}
