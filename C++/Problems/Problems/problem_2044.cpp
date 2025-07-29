#include "problem_2044.h"

bool problem_2044::test() {
    std::vector nums { 3, 2, 1, 5 };

    auto expected = 6;

    auto result = countMaxOrSubsets(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2044::countMaxOrSubsets(std::vector<int> &nums) {
    std::unordered_map<int, int> counts;

    testSubset(0, 0, nums, counts);

    auto result = 0;
    for (auto value : counts)
    {
        if (value.second > result)
            result = value.second;
    }

    return result;
}

void problem_2044::testSubset(int num, int id, std::vector<int>& nums, std::unordered_map<int, int>& counts) {
    if (id >= nums.size())
        return;
    testSubset(num, id + 1, nums, counts);
    num = num | nums[id];
    if (!counts.contains(num))
        counts[num] = 1;
    else
        counts[num]++;
    testSubset(num, id + 1, nums, counts);
}
