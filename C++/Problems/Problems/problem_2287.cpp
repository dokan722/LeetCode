#include "problem_2287.h"

bool problem_2287::test() {
    std::string s = "ilovecodingonleetcode";
    std::string target = "code";

    int expected = 2;

    auto result = rearrangeCharacters(s, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2287::rearrangeCharacters(std::string s, std::string target) {
    std::vector counts(26, 0);
    std::vector countsT(26, 0);
    for (auto c : s)
        counts[c - 'a']++;
    for (auto c : target)
        countsT[c - 'a']++;
    int result = INT_MAX;
    for (int i = 0; i < 26; ++i)
        if (countsT[i] != 0)
            result = std::min(result, counts[i] / countsT[i]);
    return result;
}
