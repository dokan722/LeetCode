#include "problem_848.h"

bool problem_848::test() {
    std::string s = "abc";
    std::vector shifts  { 3, 5, 9 };

    std::string expected = "rpl";

    auto result = shiftingLetters(s, shifts);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_848::shiftingLetters(std::string s, std::vector<int> &shifts) {
    int n = s.size();
    long cur = 0;
    for (int i = n - 1; i >= 0; --i)
    {
        cur += shifts[i];
        s[i] = (char)((s[i] - 'a' + cur) % 26 + 'a');
    }
    return s;
}
