#include "problem_1790.h"

bool problem_1790::test() {
    std::string s1 = "bank";
    std::string s2 = "kanb";

    auto expected = true;

    auto result = areAlmostEqual(s1, s2);

    return expected == result;
}

bool problem_1790::areAlmostEqual(std::string s1, std::string s2) {
    int n = s1.size();
    std::vector<int> diffs(2);
    auto numDiffs = 0;
    for (int i = 0; i < n; i++)
    {
        if (s1[i] != s2[i])
        {
            if (numDiffs == 2)
                return false;
            diffs[numDiffs] = i;
            numDiffs++;
        }
    }

    return s1[diffs[0]] == s2[diffs[1]] && s1[diffs[1]] == s2[diffs[0]];
}
