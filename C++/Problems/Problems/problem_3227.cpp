#include "problem_3227.h"

bool problem_3227::test() {
    std::string s = "leetcoder";

    bool expected = true;

    auto result = doesAliceWin(s);

    return expected == result;
}

bool problem_3227::doesAliceWin(std::string s) {
    for (auto c : s)
    {
        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            return true;
    }

    return false;
}
