#include "problem_1003.h"

#include <stack>

bool problem_1003::test() {
    std::string s = "aabcbc";

    bool expected = true;

    auto result = isValid(s);

    return expected == result;
}

bool problem_1003::isValid(std::string s) {
    std::stack<char> stack;
    for (auto c : s)
    {
        if (c == 'c')
        {
            if (stack.empty() || stack.top() != 'b')
                return false;
            stack.pop();
            if (stack.empty() || stack.top() != 'a')
                return false;
            stack.pop();
        }
        else
            stack.push(c);
    }

    return stack.size() == 0;
}
