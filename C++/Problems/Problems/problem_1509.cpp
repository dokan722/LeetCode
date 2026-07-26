#include "problem_1509.h"

bool problem_1509::test() {
    std::vector nums { 5, 3, 2, 4 };

    int expected = 0;

    auto result = minDifference(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1509::minDifference(std::vector<int> &nums) {
    if (nums.size() < 4)
        return 0;

    int max1 = INT_MIN;
    int max2 = INT_MIN;
    int max3 = INT_MIN;
    int max4 = INT_MIN;
    int min1 = INT_MAX;
    int min2 = INT_MAX;
    int min3 = INT_MAX;
    int min4 = INT_MAX;
    for (auto n : nums)
    {
        if (n >= max1)
        {
            max4 = max3;
            max3 = max2;
            max2 = max1;
            max1 = n;
        }
        else if (n >= max2)
        {
            max4 = max3;
            max3 = max2;
            max2 = n;
        }
        else if (n >= max3)
        {
            max4 = max3;
            max3 = n;
        }
        else if (n > max4)
            max4 = n;

        if (n <= min1)
        {
            min4 = min3;
            min3 = min2;
            min2 = min1;
            min1 = n;
        }
        else if (n <= min2)
        {
            min4 = min3;
            min3 = min2;
            min2 = n;
        }
        else if (n <= min3)
        {
            min4 = min3;
            min3 = n;
        }
        else if (n < min4)
            min4 = n;
    }

    return std::min(std::min(max1 - min4, max4 - min1), std::min(max2 - min3, max3 - min2));
}
