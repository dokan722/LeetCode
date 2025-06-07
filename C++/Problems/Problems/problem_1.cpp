#include "problem_1.h"
#include <unordered_map>

bool problem_1::test() {
    auto nums = std::vector{ 2, 7, 11, 15 };

    auto target = 9;

    auto expected = std::vector{ 0, 1 };

    auto result = twoSum(nums, target);

    return expected[0] == result[0] && expected[1] == result[1];
}

std::vector<int> problem_1::twoSum(std::vector<int> &nums, int target) {
    auto sumDic = std::unordered_map<int, int>();
    for (int i = 0; i < nums.size(); ++i)
    {
        auto it = sumDic.find(target - nums[i]);
        if (it != sumDic.end())
        {
                return std::vector{ it->second, i };
        }
            sumDic[nums[i]] =  i;
    }

    return std::vector{ 0, 0 };
}
