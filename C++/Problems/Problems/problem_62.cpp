#include "problem_62.h"

bool problem_62::test() {
    int m = 3;
    int n = 7;

    int expected = 28;

    auto result = uniquePaths(m, n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_62::uniquePaths(int m, int n) {
    int from = m + n - 2;
    int choose = std::min(m, n) - 1;
    int mod = 2000000000;
    long long result = 1;
    for (int i = 1; i <= choose; i++)
    {
        result = result * (from - choose + i) / i % mod;
    }

    return (int)result;
}
