#include "problem_747.h"

bool problem_747::test() {
    std::vector nums { 3, 6, 1, 0 };

    auto expected = 1;

    auto result = dominantIndex(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_747::dominantIndex(std::vector<int> &nums) {
    auto max = nums[0] > nums[1] ? 0 : 1;
    auto almostMax = nums[0] > nums[1] ? 1 : 0;

    for (int i = 2; i < nums.size(); i++)
    {
        if (nums[i] > nums[max])
        {
            almostMax = max;
            max = i;
        }
        else if (nums[i] > nums[almostMax])
        {
            almostMax = i;
        }
    }

    if (nums[max] >= 2 * nums[almostMax])
        return max;
    return -1;
}
