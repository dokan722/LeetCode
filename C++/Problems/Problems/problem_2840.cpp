#include "problem_2840.h"

bool problem_2840::test() {
    std::string s1 = "abcdba";
    std::string s2 = "cabdab";

    bool expected = true;

    auto result = checkStrings(s1, s2);

    return expected == result;
}

bool problem_2840::checkStrings(std::string s1, std::string s2) {
    int n = s1.size();
    std::vector countsEven1(26, 0);
    std::vector countsOdd1(26, 0);
    std::vector countsEven2(26, 0);
    std::vector countsOdd2(26, 0);
    for (int i = 0; i < n; ++i)
    {
        if (i % 2 == 0)
        {
            countsEven1[s1[i] - 'a']++;
            countsEven2[s2[i] - 'a']++;
        }
        else
        {
            countsOdd1[s1[i] - 'a']++;
            countsOdd2[s2[i] - 'a']++;
        }
    }

    for (int i = 0; i < 26; ++i)
    {
        if (countsEven1[i] != countsEven2[i] || countsOdd1[i] != countsOdd2[i])
            return false;
    }

    return true;
}
