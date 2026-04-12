#include "problem_1413.h"

bool problem_1413::test() {
    std::vector nums { -3, 2, -3, 4, 2 };

    int expected = 5;

    auto result = minStartValue(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1413::minStartValue(std::vector<int> &nums) {
    int minPoint = INT_MAX;
    int s = 0;
    for (auto num : nums)
    {
        s += num;
        minPoint = std::min(s, minPoint);
    }

    return minPoint > 0 ? 1 : std::abs(minPoint) + 1;
}
