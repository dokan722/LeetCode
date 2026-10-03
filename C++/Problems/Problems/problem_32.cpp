#include "problem_32.h"

bool problem_32::test() {
    std::string s = "(()";

    int expected = 2;

    auto result = longestValidParentheses(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_32::longestValidParentheses(std::string s) {
    int n = s.size();
    int cur = 0;
    int start = 0;
    int result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '(')
            cur++;
        else
            cur--;
        if (cur < 0)
        {
            start = i + 1;
            cur = 0;
        }
        if (cur == 0)
            result = std::max(result, i - start + 1);
    }
    start = n - 1;
    cur = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        if (s[i] == ')')
            cur++;
        else
            cur--;
        if (cur < 0)
        {
            start = i - 1;
            cur = 0;
        }
        if (cur == 0)
            result = std::max(result, start - i + 1);
    }

    return result;
}
