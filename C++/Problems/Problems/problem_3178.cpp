#include "problem_3178.h"

bool problem_3178::test() {
    int n = 3;
    int k = 5;

    int expected = 1;

    auto result = numberOfChild(n, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3178::numberOfChild(int n, int k) {
    int even = (k / (n - 1)) % 2 == 0;
    return even ? (k % (n - 1)) : n - (k % (n - 1)) - 1;
}
