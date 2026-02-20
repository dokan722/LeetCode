#include "problem_761.h"

bool problem_761::test() {
    std::string s = "11011000";

    std::string expected = "11100100";

    auto result = makeLargestSpecial(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_761::makeLargestSpecial(std::string s) {
    int n = s.size();
    std::vector<std::string> result;

    int level = 0;
    int last = 0;
    for (int i = 0; i < n; ++i)
    {
        if (s[i] == '0')
            level--;
        else
            level++;
        if (level == 0)
        {
            result.push_back("1" + makeLargestSpecial(s.substr(last + 1, i - last - 1)) + "0");
            last = i + 1;
        }
    }

    std::sort(result.begin(), result.end(), std::greater<std::string>());

    std::string r;
    for (auto str : result)
        r += str;
    return r;
}
