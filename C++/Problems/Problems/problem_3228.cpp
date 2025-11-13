#include "problem_3228.h"

bool problem_3228::test() {
    std::string s = "1001101";

    int expected = 4;

    auto result = maxOperations(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3228::maxOperations(std::string s) {
    int n = s.size();
    int result = 0;
    int ones = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '1')
        {
            while (i < n && s[i] == '1')
            {
                ones++;
                i++;
            }
            if (i < n)
                result += ones;
        }
    }
    return result;
}
