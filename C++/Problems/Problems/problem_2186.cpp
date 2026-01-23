#include "problem_2186.h"

bool problem_2186::test() {
    std::string s = "leetcode";
    std::string t = "coats";

    int expected = 7;

    auto result = minSteps(s, t);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2186::minSteps(std::string s, std::string t) {
    std::vector counts(26, 0);
    for (auto c : s)
        counts[c - 'a']++;
    for (auto c : t)
        counts[c - 'a']--;
    int result = 0;
    for (int i = 0; i < 26; ++i)
        result += std::abs(counts[i]);
    return result;
}
