#include "problem_2210.h"

bool problem_2210::test() {
    std::vector nums { 2, 4, 1, 1, 6, 5 };

    auto expected = 3;

    auto result = countHillValley(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2210::countHillValley(std::vector<int> &nums) {
    int n = nums.size();
    auto result = 0;
    auto prev = 0;
    for (int i = 1; i < n - 1; ++i)
    {
        while (i < n && nums[i] == nums[prev])
            i += 1;
        if (i == n)
            break;
        auto next = i;
        while (next < n && nums[next] == nums[i])
            next++;
        if (next == n)
            break;
        if ((nums[prev] < nums[i] && nums[next] < nums[i]) ||
            (nums[prev] > nums[i] && nums[next] > nums[i]))
            result += 1;
        prev = i;
        i = next - 1;
    }

    return result;
}
