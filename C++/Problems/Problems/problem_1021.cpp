#include "problem_1021.h"

bool problem_1021::test() {
    std::string s = "(()())(())";

    std::string expected = "()()()";

    auto result = removeOuterParentheses(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1021::removeOuterParentheses(std::string s) {
    int n = s.size();
    std::string result = "";
    int d = 0;
    int start = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '(')
            d++;
        else
            d--;
        if (d == 0)
        {
            result += s.substr(start + 1, i - start - 1);
            start = i + 1;
        }
    }

    return result;
}
