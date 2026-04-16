#include "problem_520.h"

bool problem_520::test() {
    std::string word = "USA";

    bool expected = true;

    auto result = detectCapitalUse(word);

    std::cout << result << std::endl;

    return result == expected;
}

bool problem_520::detectCapitalUse(std::string word) {
    int n = word.size();
    if (n == 1)
        return true;
    bool big = word[1] < 'a';
    if (big && word[0] >= 'a')
        return false;
    for (int i = 2; i < n; ++i)
        if (big != word[i] < 'a')
            return false;

    return true;
}
