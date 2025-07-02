#include "problem_3461.h"

#include <sstream>

bool problem_3461::test() {
    std::string s = "3902";

    auto expected = true;

    auto result = hasSameDigits(s);

    return expected == result;
}

bool problem_3461::hasSameDigits(std::string s) {
    while (s.size() > 2)
    {
        std::ostringstream sb;
        for (int i = 1; i < s.size(); i++)
        {
            sb << (char)('0' + (s[i - 1] + s[i] - 2 * '0') % 10);
        }

        s = sb.str();
    }

    return s[0] == s[1];
}
