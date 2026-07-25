#include "problem_3871.h"

bool problem_3871::test() {
    int n = 1002;

    long long  expected = 3;

    auto result = countCommas(n);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3871::countCommas(long long n) {
    long long result = 0;
    for (long long i = 1000; i <= n; i *= 1000)
        result += n - i + 1;
    return result;
}
