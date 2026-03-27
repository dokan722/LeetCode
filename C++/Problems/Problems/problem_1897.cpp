#include "problem_1897.h"

bool problem_1897::test() {
    std::vector<std::string> words  { "abc", "aabc", "bc" };

    bool expected = true;

    auto result = makeEqual(words);

    return result == expected;
}

bool problem_1897::makeEqual(std::vector<std::string> &words) {
    int n = words.size();
    std::vector counts(26, 0);
    for (auto &word : words)
    {
        for (auto c : word)
            counts[c - 'a']++;
    }
    for (int i = 0; i < 26; ++i)
    {
        if (counts[i] % n != 0)
            return false;
    }

    return true;
}
