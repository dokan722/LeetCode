#include "problem_2904.h"

bool problem_2904::test() {
    std::string s = "100011001";
    int k = 3;

    std::string expected = "11001";

    auto result = shortestBeautifulSubstring(s, k);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_2904::shortestBeautifulSubstring(std::string s, int k) {
    int n = s.size();
    std::string result = "";
    int i = 0;
    while (i < n && s[i] != '1')
        i++;
    if (i == n)
        return result;
    if (k == 1)
        return "1";
    int cur = 1;
    int last = i;
    for (i++; i < n; ++i)
    {
        if (s[i] == '1')
        {
            if (cur < k)
            {
                cur++;
            }
            else
            {
                last++;
                while (s[last] != '1')
                    last++;
            }
            if (cur == k)
            {
                std::string res = s.substr(last, i - last + 1);
                if (result == "" || result.size() > res.size() || (result.size() == res.size() && res < result))
                    result = res;
            }
        }
    }

    return result;
}
