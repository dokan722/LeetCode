#include "problem_1963.h"

bool problem_1963::test() {
    std::string s = "][][";

    int expected = 1;

    auto result = minSwaps(s);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1963::minSwaps(std::string s) {
    int cur = 0;
    int result = 0;
    for (auto c : s)
    {
        if (c == ']')
            cur--;
        else
            cur++;
        if (cur < 0)
        {
            result++;
            cur += 2;
        }
    }

    return result;
}
