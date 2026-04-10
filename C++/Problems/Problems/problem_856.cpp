#include "problem_856.h"

bool problem_856::test() {
    std::string s = "()()";

    int expected = 2;

    auto result = scoreOfParentheses(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_856::scoreOfParentheses(std::string s) {
    int n = s.size();
    int depth = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '(')
            depth++;
        else
        {
            depth--;
            if (s[i - 1] == '(')
                result += 1 << depth;
        }
    }
    return result;
}
