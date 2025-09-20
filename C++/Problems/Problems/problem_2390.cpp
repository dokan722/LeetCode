#include "problem_2390.h"

#include <algorithm>
#include <stack>

bool problem_2390::test() {
    std::string s = "leet**cod*e";

    std::string expected = "lecoe";

    auto result = removeStars(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_2390::removeStars(std::string s) {
    std::stack<char> stack;
    for (auto c : s)
    {
        if (c == '*')
            stack.pop();
        else
            stack.push(c);
    }

    int size = stack.size();
    std::string result(size, '\0');
    for (int i = 0; i < size; i++) {
        result[size - i - 1] = stack.top();
        stack.pop();
    }
    return result;
}
