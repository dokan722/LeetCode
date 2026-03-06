#include "problem_1784.h"

bool problem_1784::test() {
    std::string s = "1001";

    bool expected = false;

    auto result = checkOnesSegment(s);

    return expected == result;
}

bool problem_1784::checkOnesSegment(std::string s) {
    int n = s.size();
    for (int i = n - 1; i > 0; --i)
    {
        if (s[i] == '1' && s[i - 1] == '0')
            return false;
    }

    return true;
}
