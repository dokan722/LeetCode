#include "problem_1967.h"

#include <unordered_set>

bool problem_1967::test() {
    std::vector<std::string> patterns { "a", "abc", "bc", "d" };
    std::string word = "abc";

    int expected = 3;

    auto result = numOfStrings(patterns, word);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1967::numOfStrings(std::vector<std::string> &patterns, std::string word) {
    int n = word.size();
    std::unordered_set<std::string> present;
    std::unordered_set<std::string> notPresent;
    int result = 0;
    for (auto p : patterns)
    {
        if (present.contains(p))
            result++;
        else if (!notPresent.contains(p))
        {
            int m = p.size();
            std::vector<int> prefs(m);
            prefs[0] = 0;
            int l = 0;
            int d = 1;
            while (d < m)
            {
                if (p[d] == p[l])
                {
                    l++;
                    prefs[d] = l;
                    d++;
                }
                else
                {
                    if (l != 0)
                        l = prefs[l - 1];
                    else
                    {
                        prefs[d] = 0;
                        d++;
                    }
                }
            }
            l = 0;
            d = 0;
            while (d < n)
            {
                if (l == m)
                    break;
                if (word[d] == p[l])
                {
                    l++;
                    d++;
                }
                else if (l != 0)
                    l = prefs[l - 1];
                else
                    d++;
            }
            if (l == m)
            {
                present.insert(p);
                result++;
            }
            else
                notPresent.insert(p);
        }
    }
    return result;
}
