#include "problem_1422.h"

bool problem_1422::test() {
    std::string s = "1111";

    auto expected = 3;

    auto result = maxScore(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1422::maxScore(std::string s) {
    auto ones = 0;
    auto n = s.length();
    for (int i = 1; i < n; i++)
        if (s[i] == '1')
            ones++;
    auto zeros = 0;
    auto result = ones;
    if (s[0] == '1')
        ones++;
    for (int i = 0; i < n - 1; i++)
    {
        if (s[i] == '1')
            ones--;
        else
        {
            zeros++;
            if (zeros + ones > result)
                result = zeros + ones;
        }
    }

    return result;
}
