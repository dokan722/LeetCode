#include "problem_3271.h"

bool problem_3271::test() {
    std::string s = "abcd";
    int k = 2;

    std::string expected = "bf";

    auto result = stringHash(s, k);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3271::stringHash(std::string s, int k) {
    int n = s.size();
    int hash = s[0] - 'a';
    std::string result = "";
    for (int i = 1; i < n; ++i)
    {
        if (i % k != 0)
        {
            hash += s[i] - 'a';
        }
        else
        {
            result += (char)('a' + hash % 26);
            hash = s[i] - 'a';
        }
    }

    return result + (char)('a' + hash % 26);
}
