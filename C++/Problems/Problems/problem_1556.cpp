#include "problem_1556.h"

#include <iostream>
#include <bits/ostream.tcc>

bool problem_1556::test() {
    auto n = 2137;

    auto expected = "2.137";

    auto result = thousandSeparator(n);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_1556::thousandSeparator(int n) {
    if (n == 0)
        return "0";
    std::string result;

    while (n != 0)
    {
        auto mod = n % 1000;
        n -= mod;

        if (n != 0)
        {
            auto modS = std::to_string(mod);
            result = ("." + std::string(3 - modS.size(), '0') + modS).append(result);
            n /= 1000;
        }
        else
        {
            result = std::to_string(mod).append(result);
        }
    }



    return result;
}
