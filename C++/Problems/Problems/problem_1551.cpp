#include "problem_1551.h"

bool problem_1551::test() {
    int n = 3;

    int expected = 2;

    auto result = minOperations(n);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1551::minOperations(int n) {
    int half = n / 2;
    if (n % 2 == 1)
        return half * (half + 1);
    return n * (n - 1) / 2 - half * (half - 1);
}
