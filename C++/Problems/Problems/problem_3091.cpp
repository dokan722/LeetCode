#include "problem_3091.h"

bool problem_3091::test() {
    int k = 11;

    int expected = 5;

    auto result = minOperations(k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3091::minOperations(int k) {
    if (k == 1)
        return 0;
    int x = (int)std::sqrt(k - 1);
    return std::min(x - 1 + (k - 1) / x, x + (k - 1) / (x + 1));
}
