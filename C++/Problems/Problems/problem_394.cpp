#include "problem_394.h"

bool problem_394::test() {
    std::string s = "3[a]2[bc]";

    std::string expected = "aaabcbc";

    auto result = decodeString(s);

    std::cout << result << std::endl;

    return result == expected;
}

std::string problem_394::decodeString(std::string s) {
    int i = 0;
    return decode(s, i);
}

std::string problem_394::decode(std::string s, int& i) {
    std::string result = "";
    std::string phrase = "";
    int nums = 0;
    while (i < s.size())
    {
        if (std::isdigit(s[i]))
        {
            nums = nums * 10 + (s[i] - '0');
            ++i;
        }
        else if (s[i] == '[')
        {
            ++i;
            phrase = decode(s, i);
            for (int j = 0; j < nums; ++j)
                result += phrase;
            nums = 0;
        }
        else if (s[i] == ']')
        {
            ++i;
            return result;
        }
        else
        {
            result += s[i];
            ++i;
        }
    }

    return result;
}
