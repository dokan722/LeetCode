#include "problem_693.h"

bool problem_693::test() {
    int n = 11;

    bool expected = false;

    auto result = hasAlternatingBits(n);

    return expected == result;
}

bool problem_693::hasAlternatingBits(int n) {
    int x = n ^ (n >> 1);
    return (x & (x + 1)) == 0;
}
