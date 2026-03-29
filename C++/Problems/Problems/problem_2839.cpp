#include "problem_2839.h"

bool problem_2839::test() {
    std::string s1 = "abcd";
    std::string s2 = "cdab";

    bool expected = true;

    auto result = canBeEqual(s1, s2);

    return result == expected;
}

bool problem_2839::canBeEqual(std::string s1, std::string s2) {
    int n = s1.size();
    for (int i = 0; i < n - 2; ++i)
    {
        if ((s1[i] != s2[i] || s1[i + 2] != s2[i + 2]) && (s1[i] != s2[i + 2] || s1[i + 2] != s2[i]))
            return false;
    }

    return true;
}
