#include "problem_3612.h"

#include <algorithm>

bool problem_3612::test() {
    std::string s = "a#b%*";

    std::string expected = "ba";

    auto result = processStr(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_3612::processStr(std::string s) {
    std::string result;
    for (auto c : s)
    {
        if (c == '*')
        {
            if (result.size() > 0)
                result = result.substr(0, result.size() - 1);
        }
        else if (c == '#')
            result += result;
        else if (c == '%')
            result = std::string(result.rbegin(), result.rend());
        else
            result += c;
    }

    return result;
}
