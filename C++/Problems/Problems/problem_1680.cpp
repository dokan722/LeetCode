#include "problem_1680.h"

bool problem_1680::test() {
    int n = 12;

    int expected = 505379714;

    auto result = concatenatedBinary(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1680::concatenatedBinary(int n) {
    int currPow = 2;
    long long result = 0;
    int mod = 1000000007;
    for (int i = 1; i <= n; ++i)
    {
        if (currPow == i)
            currPow *= 2;
        result = (result * currPow + i) % mod;
    }

    return (int)result;
}
