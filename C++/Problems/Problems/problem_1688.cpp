#include "problem_1688.h"

bool problem_1688::test() {
    auto n = 7;

    auto expected = 6;

    auto result = numberOfMatches(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1688::numberOfMatches(int n) {
    auto result = 0;
    while (n > 1)
    {
        if (n % 2 == 0)
            result += (n /= 2);
        else
        {
            result += (n - 1) / 2;
            n = (n - 1) / 2 + 1;
        }
    }

    return result;
}
