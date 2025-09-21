#include "problem_1221.h"

bool problem_1221::test() {
    std::string s = "RLRRLLRLRL";

    int expected = 4;

    auto result = balancedStringSplit(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1221::balancedStringSplit(std::string s) {
    int ls = 0;
    int rs = 0;
    int result = 0;
    for (auto c : s)
    {
        if (c == 'L')
            ls++;
        else
            rs++;
        if (ls == rs)
        {
            result++;
            ls = 0;
            rs = 0;
        }
    }

    return result;
}
