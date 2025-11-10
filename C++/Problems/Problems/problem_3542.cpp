#include "problem_3542.h"

#include <stack>

bool problem_3542::test() {
    std::vector nums  { 3, 1, 2, 1 };

    int expected = 3;

    auto result = minOperations(nums);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3542::minOperations(std::vector<int> &nums) {
    std::stack<int> stack;
    int result = 0;
    for (auto num : nums)
    {
        while (!stack.empty() && stack.top() >= num)
        {
            if (stack.top() != num)
                result++;
            stack.pop();
        }
        stack.push(num);
    }

    while (!stack.empty())
    {
        if (stack.top() != 0)
            result++;
        stack.pop();
    }

    return result;
}

