#include "problem_413.h"

bool problem_413::test() {
    std::vector nums { 1, 2, 3, 4 };

    int expected = 3;

    auto result = numberOfArithmeticSlices(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_413::numberOfArithmeticSlices(std::vector<int> &nums) {
    int n = nums.size();
    if (n < 3)
        return 0;
    int result = 0;
    int start = 0;
    int prevDiff = nums[0] - nums[1];
    for (int i = 2; i < n; i++)
    {
        int diff = nums[i - 1] - nums[i];
        if (diff == prevDiff)
            continue;
        int len = i - start;
        if (len >= 3)
            result += (len - 2) * (len - 1) / 2;
        start = i - 1;
        prevDiff = diff;
    }
    int final = n - start;
    if (final >= 3)
        result += (final - 2) * (final - 1) / 2;

    return result;
}
