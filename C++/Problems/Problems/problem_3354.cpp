#include "problem_3354.h"

bool problem_3354::test() {
    std::vector nums { 1, 0, 2, 0, 3 };

    int expected = 2;

    auto result = countValidSelections(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3354::countValidSelections(std::vector<int> &nums) {
    int n = nums.size();
    int s = 0;
    for (auto num : nums)
        s += num;

    int result = 0;
    int curr = 0;
    for (int i = 0; i < n; ++i)
    {
        curr += nums[i];
        if (nums[i] == 0)
        {
            int diff = std::abs(2 * curr - s);
            result += 2 - std::min(diff, 2);
        }

    }

    return result;
}
