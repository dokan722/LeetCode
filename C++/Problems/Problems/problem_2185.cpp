#include "problem_2185.h"

bool problem_2185::test() {
    std::vector<std::string> words { "pay", "attention", "practice", "attend" };
    std::string pref = "at";

    int expected = 2;

    auto result = prefixCount(words, pref);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2185::prefixCount(std::vector<std::string> &words, std::string pref) {
    int n = pref.size();
    int result = 0;
    for (const auto& word : words)
    {
        if (word.size() >= n && pref == word.substr(0, n))
            result++;
    }

    return result;
}
