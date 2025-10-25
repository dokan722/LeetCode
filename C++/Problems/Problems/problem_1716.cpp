#include "problem_1716.h"

bool problem_1716::test() {
    int n = 20;

    int expected = 96;

    auto result = totalMoney(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1716::totalMoney(int n) {
    int full = n / 7;
    int rest = n % 7;
    return 7 * full * (full - 1) / 2 + 28 * full + rest * full + rest * (rest + 1) / 2;
}
