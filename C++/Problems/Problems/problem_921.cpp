#include "problem_921.h"

bool problem_921::test() {
    std::string s = "())";

    int expected = 1;

    auto result = minAddToMakeValid(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_921::minAddToMakeValid(std::string s) {
    int result = 0;
    int cur = 0;
    for (auto c : s)
    {
        if (c == '(')
            cur++;
        else
        {
            if (cur == 0)
                result++;
            else
                cur--;
        }
    }

    return result + cur;
}
