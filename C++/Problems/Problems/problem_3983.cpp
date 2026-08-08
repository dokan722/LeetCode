#include "problem_3983.h"

bool problem_3983::test() {
    std::string s = "cat";
    std::string t = "chat";

    bool expected = true;

    auto result = canMakeSubsequence(s, t);

    return result == expected;
}

bool problem_3983::canMakeSubsequence(std::string s, std::string t) {
    int n = t.size();
    int m = s.size();
    if (m > n)
        return false;
    std::vector<int> suf(n);
    int c = 0;
    int j = m - 1;
    for (int i = n - 1; i >= 0; --i)
    {
        suf[i] = c;
        if (j > 0 && t[i] == s[j])
        {
            c++;
            j--;
        }
    }
    j = 0;
    bool changed = false;
    for (int i = 0; i < n && j < m; ++i)
    {
        if (s[j] == t[i])
            j++;
        else if (!changed && suf[i] >= m - j - 1)
        {
            j++;
            changed = true;
        }
    }

    return j == m;
}
