#include "problem_456.h"

#include <stack>

bool problem_456::test() {
    std::vector nums { 1, 2, 3, 4 };

    bool expected = false;

    auto result = find132pattern(nums);

    return result == expected;
}

bool problem_456::find132pattern(std::vector<int> &nums) {
    int n = nums.size();
    int two = INT_MIN;
    std::stack<int> stack;
    for (int i = n - 1; i >= 0; i--)
    {
        if (nums[i] < two)
            return true;
        while (!stack.empty() && nums[i] > stack.top())
        {
            two = stack.top();
            stack.pop();
        }
        stack.push(nums[i]);
    }

    return false;
}
