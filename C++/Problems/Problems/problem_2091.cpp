#include "problem_2091.h"

bool problem_2019::test() {
    std::vector nums { 2, 10, 7, 5, 4, 1, 8, 6 };

    int expected = 5;

    auto result = minimumDeletions(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2019::minimumDeletions(std::vector<int> &nums) {
    int n = nums.size();
    int maxId = 0;
    int minId = 0;
    for (int i = 1; i < n; ++i)
    {
        if (nums[i] > nums[maxId])
            maxId = i;
        else if (nums[i] < nums[minId])
            minId = i;
    }
    int first = std::min(maxId, minId);
    int second = std::max(maxId, minId);
    return std::min(second + 1, std::min(n - first, first + 1 + (n - second)));
}
