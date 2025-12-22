#include "problem_3324.h"

bool problem_3324::test() {
    std::string target = "abc";

    std::vector<std::string> expected { "a", "aa", "ab", "aba", "abb", "abc" };

    auto result = stringSequence(target);

    print1DVector(result);

    return result == expected;
}

std::vector<std::string> problem_3324::stringSequence(std::string target) {
    std::vector<std::string> result;
    std::string curr = "";
    for (auto c : target)
    {
        for (int i = 'a'; i <= c; ++i)
        {
            result.push_back(curr + (char)i);
        }

        curr += c;
    }

    return result;
}
