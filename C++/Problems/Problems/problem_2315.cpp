#include "problem_2315.h"

bool problem_2315::test() {
    std::string s = "l|*e*et|c**o|*de|";

    auto expected = 2;

    auto result = countAsterisks(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2315::countAsterisks(std::string s) {
    auto result = 0;
    auto count = 0;
    auto inside = false;
    for (char c : s)
    {
        if (c == '*')
            count++;
        else if (c == '|')
        {
            if (!inside)
                result += count;
            count = 0;
            inside = !inside;
        }
    }

    result += count;

    return result;
}
