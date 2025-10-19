#include "problem_1456.h"

bool problem_1456::test() {
    std::string s = "abciiidef";
    int k = 3;

    int expected = 3;

    auto result = maxVowels(s, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1456::maxVowels(std::string s, int k) {
    int n = s.size();
    int curr = 0;
    for (int i = 0; i < k; ++i)
    {
        if (isVowel(s[i]))
            curr++;
    }

    int result = curr;
    for (int i = k; i < n; ++i)
    {
        curr += isVowel(s[i]) ? 1 : 0;
        curr -= isVowel(s[i - k]) ? 1 : 0;
        result = std::max(curr, result);
    }

    return result;
}

bool problem_1456::isVowel(char c) {
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
        return true;
    return false;
}
