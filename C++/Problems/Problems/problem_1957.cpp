#include "problem_1957.h"

#include <sstream>

bool problem_1957::test() {
    std::string s = "leeetcode";

    std::string expected = "leetcode";

    auto result = makeFancyString(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1957::makeFancyString(std::string s) {
    std::string result = "";
    result += s[0];

    auto count = 1;
    for (int i = 1; i < s.size(); ++i)
    {
        if (s[i] == s[i - 1])
            count++;
        else
            count = 1;
        if (count < 3)
            result += s[i];

    }

    return result;
}
