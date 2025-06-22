#include "problem_2138.h"

bool problem_2138::test() {
    auto s = "abcdefghi";
    auto k = 3;
    auto fill = 'x';

    std::vector<std::string> expected  { "abc", "def", "ghi" };

    auto result = divideString(s, k, fill);

    return result == expected;
}

std::vector<std::string> problem_2138::divideString(std::string s, int k, char fill) {

    std::vector<std::string> result;
    auto rest = s.size() % k;
    if (rest != 0)
        s = s + std::string(k - rest, fill);
    for (int i = 0; i < s.size(); i += k)
    {
        result.push_back(s.substr(i, k));
    }

    return result;
}
