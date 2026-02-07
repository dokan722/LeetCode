#include "problem_2938.h"

bool problem_2938::test() {
    std::string s = "101";

    int expected = 1;

    auto result = minimumSteps(s);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2938::minimumSteps(std::string s) {
    int n = s.size();
    int l = 0;
    long result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '0')
        {
            result += i - l++;
        }
    }

    return result;
}
