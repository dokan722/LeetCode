#include "problem_791.h"

bool problem_791::test() {
    std::string order = "cba";
    std::string s = "abcd";

    std::string expected = "cbad";

    auto result = customSortString(order, s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_791::customSortString(std::string order, std::string s) {
    std::vector counts(26, 0);
    for (auto c : s)
        counts[c - 'a']++;

    std::string result = "";
    for (auto c : order)
    {
        result += std::string(counts[c - 'a'], c);
        counts[c - 'a'] = 0;
    }

    for (int i = 0; i < counts.size(); ++i)
    {
        result += std::string(counts[i], (char)(i + 'a'));
    }

    return result;
}
