#include "problem_5.h"

#include <iostream>
#include <ostream>

bool problem_5::test() {
    auto n = "cbbd";

    auto expected = "bb";

    auto result = longestPalindrome(n);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_5::longestPalindrome(std::string s) {
    std::string longest = std::string(1, s[0]);

    for (int i = 0; i < s.size() - 1; i++)
    {
        auto odd = checkOdd(s, i);
        auto oddSub = s.substr(i - odd + 1, 2 * odd - 1);
        if (oddSub.size() > longest.size())
            longest = oddSub;
        auto even = checkEven(s, i);
        auto evenSub = s.substr(i - even + 1, 2 * even);
        if (evenSub.size() > longest.size())
            longest = evenSub;
    }
    return longest;
}

int problem_5::checkOdd(std::string s, int i) {
    auto side = 1;
    while (i + side < s.size() && i - side >= 0)
    {

        if (s[i + side] != s[i - side])
            return side;
        side++;
    }

    return side;
}

int problem_5::checkEven(std::string s, int i) {
    if (s[i] != s[i + 1])
        return 0;
    auto side = 1;

    while (i + side + 1 < s.size() && i - side >= 0)
    {
        if (s[i + side + 1] != s[i - side])
            return side;
        side++;
    }

    return side;
}
