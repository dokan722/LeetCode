#include "problem_3746.h"

bool problem_3746::test() {
    std::string s = "aabbab";

    int expected = 0;

    auto result = minLengthAfterRemovals(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3746::minLengthAfterRemovals(std::string s) {
    int na = 0;
    for (auto c : s)
    {
        if (c == 'a')
            na++;
    }

    return std::abs((int)s.size() - 2 * na);
}
