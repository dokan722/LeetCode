#include "problem_3849.h"

bool problem_3849::test() {
    std::string s = "101";
    std::string t = "011";

    std::string expected = "110";

    auto result = maximumXor(s, t);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_3849::maximumXor(std::string s, std::string t) {
    int n = s.size();
    int ones = 0;
    for (auto c : t)
        if (c == '1')
            ones++;
    int zeros = n - ones;
    std::string result = "";
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '0')
        {
            if (ones > 0)
            {
                result += '1';
                ones--;
            }
            else
            {
                result += '0';
                zeros--;
            }
        }
        else
        {
            if (zeros > 0)
            {
                result += '1';
                zeros--;
            }
            else
            {
                result += '0';
                ones--;
            }
        }
    }

    return result;
}
