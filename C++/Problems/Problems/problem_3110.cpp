#include "problem_3110.h"

bool problem_3110::test() {
    std::string s = "hello";

    int expected = 13;

    auto result = scoreOfString(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_3110::scoreOfString(std::string s) {
    int n = s.size();
    int result = 0;
    for(int i = 1; i < n; ++i)
        result += std::abs(s[i] - s[i - 1]);

    return result;
}
