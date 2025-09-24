#include "problem_166.h"

#include <unordered_map>

bool problem_166::test() {
    int numerator = 4;
    int denominator = 333;

    std::string expected = "0.(012)";

    auto result = fractionToDecimal(numerator, denominator);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_166::fractionToDecimal(int numerator, int denominator) {
    std::string sign = numerator <= 0 && denominator < 0 || numerator >= 0 && denominator > 0 ? "" : "-";
    long long n = std::abs((long)numerator);
    long long d = std::abs((long)denominator);
    std::string integer = std::to_string(n / d);
    n %= d;
    if (n == 0)
        return sign + integer;
    std::string frac = "";
    std::unordered_map<long long, int> numerators;
    int repeat = -1;
    for (int i = 0; i < 10000; ++i)
    {
        n *= 10;
        if (numerators.contains(n))
        {
            repeat = numerators[n];
            break;
        }

        numerators[n] = i;
        int digit = n / d;
        frac += (char)('0' + digit);
        n %= d;
        if (n == 0)
            break;
    }
    if (repeat != -1)
        frac = frac.substr(0, repeat) + "(" + frac.substr(repeat) + ")";

    return sign + integer + "." + frac;
}
