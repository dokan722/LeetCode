#include "problem_2109.h"

#include <sstream>

bool problem_2109::test() {
    std::string s = "LeetcodeHelpsMeLearn";
    std::vector spaces { 8, 13, 15 };

    std::string expected = "Leetcode Helps Me Learn";

    auto result = addSpaces(s, spaces);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2109::addSpaces(std::string s, std::vector<int> &spaces) {
    int index = 0;
    std::ostringstream result;
    for (auto space : spaces)
    {
        result << s.substr(index, space - index);
        result << " ";
        index = space;
    }

    result << s.substr(index);
    return result.str();
}
