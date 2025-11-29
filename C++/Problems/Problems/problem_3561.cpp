#include "problem_3561.h"

#include <algorithm>
#include <stack>

bool problem_3561::test() {
    std::string s = "zadb";

    std::string expected = "db";

    auto result = resultingString(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3561::resultingString(std::string s) {
    std::stack<char> chars;
    for (char c : s)
    {
        if (!chars.empty())
        {
            char top = chars.top();
            int diff = (top - c + 26) % 26;
            if (diff == 1 || diff == 25)
                chars.pop();
            else
                chars.push(c);
        }
        else
            chars.push(c);
    }

    std::vector<char> result;
    while (!chars.empty())
    {
        char c = chars.top();
        chars.pop();
        result.push_back(c);
    }

    std::reverse(result.begin(), result.end());
    return std::string(result.begin(), result.end());
}
