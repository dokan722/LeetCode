#include "problem_1910.h"

bool problem_1910::test() {
    std::string s = "daabcbaabcbc";
    std::string part = "abc";

    std::string expected = "dab";

    auto result = removeOccurrences(s, part);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1910::removeOccurrences(std::string s, std::string part) {
    auto index = s.find(part);
    while (index != -1)
    {
        s = s.substr(0, index) + s.substr(index + part.size());
        index = s.find(part);
    }

    return s;
}
