#include "problem_2828.h"

bool problem_2828::test() {
    std::vector<std::string> words { "alice", "bob", "charlie" };
    std::string s = "abc";

    bool expected = true;

    auto result = isAcronym(words, s);

    return expected == result;
}

bool problem_2828::isAcronym(std::vector<std::string> &words, std::string s) {
    int n = words.size();
    int m = s.size();
    if (n != m)
        return false;
    for (int i = 0; i < n; ++i)
    {
        if (words[i][0] != s[i])
            return false;
    }

    return true;
}
