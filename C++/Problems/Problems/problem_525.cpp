#include "problem_525.h"

#include <unordered_map>

bool problem_525::test() {
    std::vector nums {0, 1, 1, 1, 1, 1, 0, 0, 0};
    auto expected = 6;

    auto result = findMaxLength(nums);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_525::findMaxLength(std::vector<int> &nums) {
    std::unordered_map<int, int> ids;
    ids[0] = 0;
    auto runningSum = 0;
    auto result = 0;
    for (int i  = 0; i < nums.size(); ++i)
    {
        if (nums[i] == 0)
            runningSum -= 1;
        else
            runningSum += 1;
        if (ids.contains(runningSum))
        {
            auto id = ids[runningSum];
            auto length = i - id;
            if (length > result)
                result = length;
        }
        else
            ids[runningSum] = i;
    }

    return result;
}
