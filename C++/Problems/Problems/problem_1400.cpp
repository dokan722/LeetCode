#include "problem_1400.h"

bool problem_1400::test() {
    std::string s = "annabelle";
    int k = 2;

    bool expected = true;

    auto result = canConstruct(s, k);

    return result == expected;
}

bool problem_1400::canConstruct(std::string s, int k) {
    if (s.size() < k)
        return false;
    std::vector counts(26, 0);
    for (auto c : s)
        counts[c - 'a']++;
    int odd = 0;
    for (int i = 0; i < 26; ++i)
        if (counts[i] % 2 == 1)
            odd++;
    return odd <= k;
}
