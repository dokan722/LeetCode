#include "problem_1523.h"

bool problem_1523::test() {
    int low = 3;
    int high = 7;

    int expected = 3;

    auto result = countOdds(low, high);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1523::countOdds(int low, int high) {
    int l = high - low + 1;
    if (l % 2 == 0)
        return l / 2;
    if (low % 2 == 1)
        return (l + 1) / 2;
    return (l - 1) / 2;
}
