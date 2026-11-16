#include "problem_2243.h"

bool problem_2243::test() {
    std::string s = "11111222223";
    int k = 3;

    std::string expected = "135";

    auto result = digitSum(s, k);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2243::digitSum(std::string s, int k) {
    while (s.size() > k)
    {
        int groups = (s.size() + k - 1) / k;
        std::string next = "";
        for (int i = 0; i < groups; ++i)
        {
            int cur = 0;
            int sh = i * k;
            int size = std::min(k, (int)s.size() - sh);
            for (int j = 0; j < size; ++j)
                cur += s[sh + j] - '0';
            next += std::to_string(cur);
        }
        s = next;
    }

    return s;
}
