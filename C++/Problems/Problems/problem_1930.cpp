#include "problem_1930.h"

#include <unordered_set>

bool problem_1930::test() {
    std::string s = "bbcbaba";

    int expected = 4;

    auto result = countPalindromicSubsequence(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1930::countPalindromicSubsequence(std::string s) {
    int n = s.size();
    std::vector counts(26, 0);
    for (int i = 0; i < n; ++i)
        counts[s[i] - 'a']++;

    std::vector currCounts(26, 0);
    std::unordered_set<int> allPals;
    for (int i = 0; i < n; ++i)
    {
        int id = s[i] - 'a';
        counts[id]--;
        for (int j = 0; j < 26; ++j)
        {
            if (counts[j] > 0 && currCounts[j] > 0)
                allPals.insert(100 * j + id);
        }

        currCounts[id]++;
    }

    return allPals.size();
}
