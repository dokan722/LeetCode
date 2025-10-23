#include "problem_1689.h"

bool problem_1689::test() {
    std::string n = "27346209830709182346";

    int expected = 9;

    auto result = minPartitions(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1689::minPartitions(std::string n) {
    char maxDigit = '1';
    for (auto i : n)
    {
        if (i > maxDigit)
        {
            if (i == '9')
                return 9;
            maxDigit = i;
        }
    }

    return maxDigit - '0';
}

