#include "problem_2730.h"

bool problem_2730::test() {
    std::string s = "52233";

    int expected = 4;

    auto result = longestSemiRepetitiveSubstring(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2730::longestSemiRepetitiveSubstring(std::string s) {
    int n = s.size();
    int bound = 0;
    int last = 0;
    int result = 0;
    for (int i = 1; i < n; ++i)
    {
        if (s[i] == s[i - 1])
        {
            result = std::max(result, i - bound);
            bound = last;
            last = i;
        }
    }
    result = std::max(result, n - bound);

    return result;
}
