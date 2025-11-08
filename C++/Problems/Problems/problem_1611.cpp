#include "problem_1611.h"

bool problem_1611::test() {
    int n = 6;

    int expected = 4;

    auto result = minimumOneBitOperations(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1611::minimumOneBitOperations(int n) {
    if (n == 1)
        return 1;

    int k = 0;
    int curr = 1;
    while (curr * 2 <= n)
    {
        curr *= 2;
        k++;
    }

    return (1 << (k + 1)) - 1 - minimumOneBitOperations(n ^ curr);
}
