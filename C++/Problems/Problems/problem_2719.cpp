#include "problem_2719.h"

bool problem_2719::test() {
    std::string s = "010101";

    int expected = 9;

    auto result = minimumCost(s);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2719::minimumCost(std::string s) {
    int n = s.size();
    long result = 0;
    for (int i = 1; i < n; ++i)
    {
        if (s[i - 1] != s[i])
            result += std::min(i, n - i);
    }
    return result;
}
