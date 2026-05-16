#include "problem_1657.h"

bool problem_1657::test() {
    std::string word1 = "abc";
    std::string word2 = "bca";

    bool expected = true;

    auto result = closeStrings(word1, word2);

    return result == expected;
}

bool problem_1657::closeStrings(std::string word1, std::string word2) {
    int n = word1.size();
    if (n != word2.size())
        return false;
    std::vector counts1(26, 0);
    std::vector counts2(26 , 0);
    for (int i = 0; i < n; ++i)
    {
        counts1[word1[i] - 'a']++;
        counts2[word2[i] - 'a']++;
    }
    for (int i = 0; i < 26; ++i)
    {
        if (std::min(counts1[i], counts2[i]) == 0 && std::max(counts1[i], counts2[i]) != 0)
            return false;
    }
    std::sort(counts1.begin(), counts1.end());
    std::sort(counts2.begin(), counts2.end());
    for (int i = 0; i < 26; ++i)
    {
        if (counts1[i] != counts2[i])
            return false;
    }

    return true;
}
