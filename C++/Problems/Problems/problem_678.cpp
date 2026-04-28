#include "problem_678.h"

bool problem_678::test() {
    std::string s = "(*))";

    bool expected = true;

    auto result = checkValidString(s);

    return expected == result;
}

bool problem_678::checkValidString(std::string s) {
    int maxDepth = 0;
    int minDepth = 0;
    for (auto c : s)
    {
        if (c == '(')
        {
            maxDepth++;
            minDepth++;
        }
        else if (c == ')')
        {
            maxDepth--;
            minDepth--;
        }
        else
        {
            maxDepth++;
            minDepth--;
        }
        if (maxDepth < 0)
            return false;
        minDepth = std::max(minDepth, 0);
    }

    return minDepth == 0;
}
