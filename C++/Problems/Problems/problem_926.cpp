#include "problem_926.h"

bool problem_926::test() {
    std::string s = "00110";

    int expected = 1;

    auto result = minFlipsMonoIncr(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_926::minFlipsMonoIncr(std::string s) {
    int ones = 0;
    int result = 0;
    for (auto c : s)
    {
        if (c == '1')
            ones++;
        else
            result = std::min(result + 1, ones);
    }

    return result;
}
