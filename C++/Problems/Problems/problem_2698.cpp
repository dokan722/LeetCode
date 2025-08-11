#include "problem_2698.h"

bool problem_2698::test() {
    auto n = 10;

    auto expected = 182;

    auto result = punishmentNumber(n);

    std::cout << result << std::endl;

    return result == expected;
}

std::vector<int> _punishmentNumbers
{
    1,
    9,
    10,
    36,
    45,
    55,
    82,
    91,
    99,
    100,
    235,
    297,
    369,
    370,
    379,
    414,
    657,
    675,
    703,
    756,
    792,
    909,
    918,
    945,
    964,
    990,
    991,
    999,
    1000,
    2137
};

int problem_2698::punishmentNumber(int n) {
    int result = 0;
    for (int i = 0; _punishmentNumbers[i] <= n; ++i)
        result += _punishmentNumbers[i] * _punishmentNumbers[i];

    return result;
}
