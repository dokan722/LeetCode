#include "problem_1513.h"

bool problem_1513::test() {
    std::string s = "0110111";

    int expected = 9;

    auto result = numSub(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1513::numSub(std::string s) {
    int n = s.size();
    int result = 0;
    int mod = 1000000007;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '1')
        {
            int start = i;
            while (i < n && s[i] ==  '1')
                ++i;
            long l = i - start;
            result += (int)(l * (l + 1) / 2 % mod);
        }
    }

    return result;
}
