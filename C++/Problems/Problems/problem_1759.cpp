#include "problem_1759.h"

bool problem_1759::test() {
    std::string s = "abbcccaa";

    int expected = 13;

    auto result = countHomogenous(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1759::countHomogenous(std::string s) {
    int n = s.size();
    int first = 0;
    long long result = 0;
    int mod = 1000000007;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] != s[first])
        {
            long long l = i - first;
            result = (result + l * (l + 1) / 2) % mod;
            first = i;
        }
    }
    long long ls = n - first;
    result = (result + ls * (ls + 1) / 2) % mod;
    return (int)result;
}
