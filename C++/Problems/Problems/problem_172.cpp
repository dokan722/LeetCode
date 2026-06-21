#include "problem_172.h"

bool problem_172::test() {
    int n = 3;

    int expected = 0;

    auto result = trailingZeroes(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_172::trailingZeroes(int n) {
    std::vector<int> powers;
    int b = 5;
    while (b <= n)
    {
        powers.push_back(b);
        b *= 5;
    }
    int result = 0;
    for (auto f : powers)
        result += n / f;
    return result;
}
