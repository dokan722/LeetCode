#include "problem_1411.h"

bool problem_1411::test() {
    int n = 5000;

    int expected = 30228214;

    auto result = numOfWays(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1411::numOfWays(int n) {
    int mod = 1000000007;
    long long two = 6;
    long long three = 6;

    for (int i = 1; i < n; i++)
    {
        long long nextTwo = (3 * two + 2 * three) % mod;
        long long nextThree = (2 * two + 2 * three) % mod;
        two = nextTwo;
        three = nextThree;
    }

    return (int)((two + three) % mod);
}
