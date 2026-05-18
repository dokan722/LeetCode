#include "problem_3895.h"

bool problem_3895::test() {
    std::vector nums { 12, 54, 32, 22 };
    int digit = 2;

    int expected = 4;

    auto result = countDigitOccurrences(nums, digit);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3895::countDigitOccurrences(std::vector<int> &nums, int digit) {
    int result = 0;
    for (auto num : nums)
    {
        int cur = num;
        while (cur > 0)
        {
            if (cur % 10 == digit)
                result++;
            cur /= 10;
        }
    }

    return result;
}
