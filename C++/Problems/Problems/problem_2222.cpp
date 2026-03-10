#include "problem_2222.h"

bool problem_2222::test() {
    std::string s = "001101";

    int expected = 6;

    auto result = numberOfWays(s);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2222::numberOfWays(std::string s) {
    int n = s.size();
    int zeros = 0;
    int ones = 0;
    long long zeroFirst = 0;
    long long oneFirst = 0;
    long long result = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '0')
        {
            result += zeroFirst;
            oneFirst += ones;
            zeros++;
        }
        else
        {
            result += oneFirst;
            zeroFirst += zeros;
            ones++;
        }
    }

    return result;
}
