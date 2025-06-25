#include "problem_984.h"

#include <iostream>
#include <ostream>
#include <sstream>

bool problem_984::test() {
    auto a = 4;
    auto b = 1;

    auto expected = "aabaa";

    auto result = strWithout3a3b(a, b);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_984::strWithout3a3b(int a, int b) {
    std::ostringstream result;

    auto domSymbol = a > b ? 'a' : 'b';
    auto other = domSymbol == 'a' ? 'b' : 'a';
    auto diff = std::abs(a - b);
    std::string rest = "";
    if (diff >= 2)
    {
        diff -= 2;
        rest = std::string(2, domSymbol);
    }
    for (int i = 0; i < std::min(a, b); i++)
    {
        if (diff > 0)
        {
            result << domSymbol;
            diff--;
        }
        result << domSymbol;
        result << other;
    }

    result << rest;

    return result.str();
}
