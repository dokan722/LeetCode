#include "problem_2311.h"

bool problem_2311::test() {
    auto s = "1001010";

    auto k = 5;

    auto expected = 5;

    auto result = longestSubsequence(s, k);

    return result == expected;
}

int problem_2311::longestSubsequence(std::string s, int k) {
    long long factor = 1;
    long long num = 0;
    int i = s.size() - 1;
    auto found = false;
    auto lastOne = s.size();
    for (; i >= 0; i--)
    {
        if (s[i] == '1')
        {
            if (num + factor <= k)
            {
                num += factor;
                lastOne = i;
                found = true;
            }
            else
                break;
        }

        if (factor > INT_MAX)
            break;
        factor *= 2;
    }

    if (i == -1)
        return s.size();
    auto zeros = 0;
    if (!found)
    {
        for (auto v : s)
            if (v == '0')
                zeros++;
        return zeros;
    }
    for (auto v : s.substr(0, lastOne))
        if (v == '0')
            zeros++;


    return s.size() - lastOne + zeros;
}
