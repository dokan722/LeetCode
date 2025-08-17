#include "problem_3039.h"

#include <algorithm>

bool problem_3039::test() {
    std::string s = "aabcbbca";

    std::string expected = "ba";

    auto result = lastNonEmptyString(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_3039::lastNonEmptyString(std::string s) {
    std::vector counts(26, 0);
    std::vector lastIds(26, 0);
    for (int i = 0; i < s.size(); i++)
    {
        counts[s[i] - 'a']++;
        lastIds[s[i] - 'a'] = i;
    }

    auto maxCount = 0;
    for (auto count : counts)
    {
        if (count > maxCount)
            maxCount = count;
    }

    std::vector<std::pair<int, char>> remainingLetters;
    for (int i = 0; i < 26; ++i)
    {
        if (counts[i] == maxCount)
            remainingLetters.push_back(std::pair(lastIds[i], i + 'a'));
    }
    std::string result = "";
    std::sort(remainingLetters.begin(), remainingLetters.end());
    for (auto letter : remainingLetters)
    {
        result += letter.second;
    }

    return result;
}
