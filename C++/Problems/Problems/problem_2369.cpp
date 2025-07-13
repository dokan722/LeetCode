#include "problem_2369.h"

#include <stack>

bool problem_2369::test() {
    std::vector nums { 4, 4, 4, 5, 6 };

    auto expected = true;

    auto result = validPartition(nums);

    return result == expected;
}

bool problem_2369::validPartition(std::vector<int> &nums) {
    int n = nums.size();
    std::stack<int> check;
    std::vector visited(n, false);
    check.push(0);
    while (!check.empty())
    {
        auto popped = check.top();
        check.pop();
        if (visited[popped])
            continue;
        if (CheckTwo(nums, popped))
        {
            auto ch = popped + 2;
            if (ch == n)
                return true;
            check.push(ch);
        }
        if (CheckThree(nums, popped))
        {
            auto ch = popped + 3;
            if (ch == n)
                return true;
            check.push(ch);
        }

        visited[popped] = true;
    }

    return false;
}

bool problem_2369::CheckTwo(std::vector<int> &nums, int index) {
    if (index + 1 >= nums.size())
        return false;
    if (nums[index] == nums[index + 1])
        return true;

    return false;
}

bool problem_2369::CheckThree(std::vector<int> &nums, int index) {
    if (index + 2 >= nums.size())
        return false;
    if (nums[index] == nums[index + 1] && nums[index + 1] == nums[index + 2])
        return true;
    if (nums[index] == nums[index + 1] - 1 && nums[index + 1] == nums[index + 2] - 1)
        return true;

    return false;
}
