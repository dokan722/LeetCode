#include "problem_696.h"

bool problem_696::test() {
    std::string s = "00110011";

    int expected = 6;

    int result = countBinarySubstrings(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_696::countBinarySubstrings(std::string s) {
    int n = s.size();
    int last = 0;
    while (last < n - 1 && s[last] == s[last + 1])
        last++;
    int result = 0;
    int prev = last + 1;
    for (int i = last + 1; i < n - 1; ++i)
    {
        if (s[i] != s[i + 1])
        {
            int curr = i - last;
            result += std::min(curr, prev);
            last = i;
            prev = curr;
        }
    }
    result += std::min(prev, n - last - 1);

    return result;
}
