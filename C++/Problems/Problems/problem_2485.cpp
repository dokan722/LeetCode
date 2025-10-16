#include "problem_2485.h"

#include <complex>

bool problem_2485::test() {
    int n = 8;

    int expected = 6;

    auto result = pivotInteger(n);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2485::pivotInteger(int n) {
    auto pivotValue = std::sqrt((n * n + n) / 2.0);
    return pivotValue == std::floor(pivotValue) ? (int)pivotValue : -1;
}
