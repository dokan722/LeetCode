#include "problem_645.h"

bool problem_645::test() {
    std::vector nums { 1, 2, 2, 4 };

    std::vector expected { 2, 3 };

    auto result = findErrorNums(nums);

    return result == expected;
}

std::vector<int> problem_645::findErrorNums(std::vector<int> &nums) {
    auto n = nums.size();
    std::vector<bool> presence(n);
    std::vector<int> result(2);
    for (auto num : nums)
    {
        if (presence[num - 1])
            result[0] = num;
        presence[num - 1] = true;
    }

    for (int i = 0; i < n; i++)
    {
        if (!presence[i])
        {
            result[1] = i + 1;
            break;
        }
    }


    return result;
}
