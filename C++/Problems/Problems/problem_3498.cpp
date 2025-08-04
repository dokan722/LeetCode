#include "problem_3498.h"

bool problem_3498::test() {
    std::string  s = "abc";

    auto expected = 148;

    auto result = reverseDegree(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3498::reverseDegree(std::string s) {
    int result = 0;

    for (int i = 0; i < s.size(); ++i)
    {
        result += (26 - (s[i] - 'a')) * (i + 1);
    }

    return result;
}
