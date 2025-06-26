#include "problem_1417.h"

#include <iostream>
#include <ostream>
#include <sstream>
#include <stack>

bool problem_1417::test() {
    std::string s = "a0b1c2";

    std::string expected = "c2b1a0";

    auto result = reformat(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_1417::reformat(std::string s) {
    std::stack<char> digits;
    std::stack<char> chars;
    for (auto c : s)
    {
        if (std::isdigit(c))
            digits.push(c);
        else
            chars.push(c);
    }

    if (std::abs((int)(digits.size() - chars.size())) >= 2)
        return "";
    std::stack<char> bigger;
    std::stack<char> smaller;
    if (digits.size() > chars.size())
    {
        bigger = digits;
        smaller = chars;
    }
    else
    {
        bigger = chars;
        smaller = digits;
    }

    std::ostringstream result;
    while (!smaller.empty())
    {
        result << bigger.top();
        bigger.pop();
        result << smaller.top();
        smaller.pop();
    }

    if (!bigger.empty())
        result << bigger.top();

    return result.str();
}
