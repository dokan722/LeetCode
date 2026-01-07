#include "problem_2486.h"

bool problem_2486::test() {
    std::string s = "coaching";
    std::string t = "coding";

    int expected = 4;

    auto result = appendCharacters(s, t);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2486::appendCharacters(std::string s, std::string t) {
    int p = 0;
    for (auto c : s)
    {
        if (t[p] == c)
        {
            p++;
            if (p == t.size())
                return 0;
        }
    }

    return t.size() - p;
}
