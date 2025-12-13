#include "problem_2414.h"

bool problem_2414::test() {
    std::string s = "abacaba";

    int expected = 2;

    auto result = longestContinuousSubstring(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2414::longestContinuousSubstring(std::string s) {
    int n = s.size();
    int result = 0;
    int start = 0;
    for (int i = 1; i < n; ++i)
    {
        if (s[i] - s[i - 1] != 1)
        {
            result = std::max(result, i - start);
            start = i;
        }
    }

    result = std::max(result, n - start);

    return result;
}
