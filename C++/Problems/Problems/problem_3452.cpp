#include "problem_3452.h"

bool problem_3452::test() {
    std::vector nums { 1, 3, 2, 1, 5, 4 };
    auto k = 2;

    auto expected = 12;

    auto result = sumOfGoodNumbers(nums, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3452::sumOfGoodNumbers(std::vector<int> &nums, int k) {
    auto result = 0;
    for (auto i = 0; i < nums.size(); i++)
    {
        if (nums[i] > getNum(i + k, nums) && nums[i] > getNum(i - k, nums))
            result += nums[i];
    }

    return result;
}

int problem_3452::getNum(int id, std::vector<int>& nums) {
    if  (id < 0 ||  id >= nums.size())
        return -1;
    return nums[id];
}
