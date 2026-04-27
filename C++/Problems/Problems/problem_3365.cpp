#include "problem_3365.h"

#include <unordered_map>

bool problem_3365::test() {
    std::string s = "abcd";
    std::string t = "cdab";
    int k = 2;

    bool expected = true;

    auto result = isPossibleToRearrange(s, t, k);

    return result == expected;
}

bool problem_3365::isPossibleToRearrange(std::string s, std::string t, int k) {
    int n = s.size();
    if (n == k)
        return true;
    int fLen = n / k;
    std::unordered_map<std::string, int> target;
    for (int i = 0; i < k; ++i)
    {
        auto f = t.substr(i * fLen, fLen);
        if (target.contains(f))
            target[f]++;
        else
            target[f] = 1;
    }
    for (int i = 0; i < k; ++i)
    {
        auto f = s.substr(i * fLen, fLen);
        if (target.contains(f))
            target[f]--;
        else
            target[f] = -1;
        if (target[f] < 0)
            return false;
    }
    for (auto e : target)
    {
        if (e.second != 0)
            return false;
    }
    return true;
}
