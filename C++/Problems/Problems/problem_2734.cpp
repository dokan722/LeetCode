#include "problem_2734.h"

bool problem_2734::test() {
    std::string s = "cbabc";

    std::string exected = "baabc";

    auto result = smallestString(s);

    std::cout << result << std::endl;

    return result == exected;
}

std::string problem_2734::smallestString(std::string s) {
    int n = s.size();
    int start = -1;
    int end = n;
    std::vector<char> map(26);
    map[0] = 'z';
    for (int i = 1; i < 26; ++i)
        map[i] = (char)('a' + i - 1);
    for (int i = 0; i < n; ++i)
    {
        if (start == -1 && s[i] != 'a')
            start = i;
        else if (start != -1 && s[i] == 'a')
        {
            end = i;
            break;
        }
    }
    if (start == -1)
        return std::string(n - 1, 'a') + "z";
    for (int i = start; i < end; ++i)
        s[i] =  map[s[i] - 'a'];
    return s;
}
