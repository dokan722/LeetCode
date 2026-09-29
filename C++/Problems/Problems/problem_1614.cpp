#include "problem_1614.h"

bool problem_1614::test() {
    std::string s = "(1+(2*3)+((8)/4))+1";

    int expected = 3;

    int result = maxDepth(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1614::maxDepth(std::string s) {
    int d = 0;
    int result = 0;
    for (auto c : s)
    {
        if (c == '(')
        {
            d++;
            result = std::max(result, d);
        }
        else if (c == ')')
            d--;
    }

    return result;
}
