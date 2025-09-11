#include "problem_2785.h"

#include <map>

bool problem_2785::test() {
    std::string s = "lEetcOde";

    std::string expected = "lEOtcede";

    auto result = sortVowels(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2785::sortVowels(std::string s) {
    std::map<char, int> vowelsDic
    {
        {'A', 0},
        {'E', 0},
        {'I', 0},
        {'O', 0},
        {'U', 0},
        {'a', 0},
        {'e', 0},
        {'i', 0},
        {'o', 0},
        {'u', 0},
    };
    for (char c : s)
        if (isVowel(c))
            vowelsDic[c]++;

    int p = 0;
    for (auto vowel : vowelsDic)
    {
        for (int i = 0; i < vowel.second; ++i)
        {
            while (!isVowel(s[p]))
                p++;
            s[p] = vowel.first;
            p++;
        }
    }

    return s;
}


bool problem_2785::isVowel(char c) {
    c = std::tolower(c);
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        return true;
    return false;
}
