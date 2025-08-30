#include "problem_316.h"

#include <stack>

bool problem_316::test() {
    std::string s = "bcabc";

    std::string expected = "abc";

    auto result = removeDuplicateLetters(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_316::removeDuplicateLetters(std::string s) {
    int n = s.size();
    std::vector indices(26, INT_MAX);
    for (int i = 0; i < n; ++i)
        indices[s[i] - 'a'] = i;
    std::stack<char> stack;
    std::vector inStack(26, false);

    for (int i = 0; i < n; ++i)
    {
        if (inStack[s[i] - 'a'])
            continue;

        while (!stack.empty() && stack.top() > s[i] && i < indices[stack.top() - 'a'])
        {
            inStack[stack.top() - 'a'] = false;
            stack.pop();
        }

        inStack[s[i] - 'a'] = true;
        stack.push(s[i]);
    }

    std::string result = "";
    while (!stack.empty()) {
        result = stack.top() + result;
        stack.pop();
    }

    return result;
}
