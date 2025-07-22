#include "problem_258.h"

bool problem_258::test() {
    auto num = 38;

    auto expected = 2;

    auto result = addDigits(num);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_258::addDigits(int num) {
    if (num == 0)
        return 0;
    return 1 + (num - 1) % 9;
}
