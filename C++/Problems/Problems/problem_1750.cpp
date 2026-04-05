#include "problem_1750.h"

bool problem_1750::test() {
    std::string s = "ca";

    int expected = 2;

    auto result = minimumLength(s);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1750::minimumLength(std::string s) {
    int n = s.size();
    int l = 0;
    int r = n - 1;
    while (l < r && l < n && r >= 0 && s[l] == s[r])
    {
        char c = s[l];
        while (l < n && s[l] == c)
            l++;
        while (r >= 0 && s[r] == c)
            r--;
    }

    if (l < r)
        return r - l + 1;
    return l == r ? 1 : 0;
}
