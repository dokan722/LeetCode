#include "problem_1968.h"

bool problem_1968::test() {
    std::vector nums { 1, 2, 3, 4, 5 };

    std::vector expected { 1, 3, 2, 5, 4 };

    auto result = rearrangeArray(nums);

    return expected == result;
}

std::vector<int> problem_1968::rearrangeArray(std::vector<int> &nums) {
    for (int i = 1; i < nums.size() - 1; i++)
    {
        if ((nums[i - 1] < nums[i] && nums[i] < nums[i + 1])
            || (nums[i - 1] > nums[i] && nums[i] > nums[i + 1]))
            std::swap(nums[i], nums[i + 1]);
    }

    return nums;
}
