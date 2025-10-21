#include "problem_2864.h"

bool problem_2864::test() {
    std::string s = "0101";

    std::string expected = "1001";

    auto result = maximumOddBinaryNumber(s);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_2864::maximumOddBinaryNumber(std::string s) {
    int zeros = 0;
    int ones = 0;
    for (auto c : s)
    {
        if (c == '0')
            zeros++;
        else
            ones++;
    }

    return std::string(ones - 1, '1') + std::string(zeros, '0') + "1";
}
