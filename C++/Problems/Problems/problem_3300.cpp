#include "problem_3300.h"

bool problem_3300::test() {
    std::vector nums { 10, 12, 13, 14 };

    int expected = 1;

    auto result = minElement(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3300::minElement(std::vector<int> &nums) {
    int result = INT_MAX;
    for (auto num : nums)
    {
        int n = num;
        int d = 0;
        while (n > 0)
        {
            d += n % 10;
            n /= 10;
        }

        result = std::min(result, d);
    }

    return result;
}
