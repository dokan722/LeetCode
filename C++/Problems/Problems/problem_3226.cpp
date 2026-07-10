#include "problem_3226.h"

bool problem_3226::test() {
    int n = 13;
    int k = 4;

    int expected = 2;

    auto result = minChanges(n, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3226::minChanges(int n, int k) {
    if ((n & k) != k)
        return -1;
    return std::popcount((unsigned)(n & ~k));
}
