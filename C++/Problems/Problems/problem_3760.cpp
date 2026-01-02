#include "problem_3760.h"

bool problem_3760::test() {
    std::string s = "abab";

    int expected = 2;

    auto result = maxDistinct(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3760::maxDistinct(std::string s) {
    std::vector seen(26, false);
    int result = 0;
    for (auto c : s)
    {
        int id = c - 'a';
        if (!seen[id])
            result++;
        seen[id] = true;
    }

    return result;
}
