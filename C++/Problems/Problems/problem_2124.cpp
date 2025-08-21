#include "problem_2124.h"

bool problem_2124::test() {
    std::string s = "aaabbb";

    auto expected = true;

    auto result = checkString(s);

    return expected == result;
}

bool problem_2124::checkString(std::string s) {
    auto bs = s[0] == 'b';
    for (auto c : s)
    {
        if (c == 'a' && bs)
            return false;
        if (c == 'b')
            bs = true;

    }

    return true;
}
