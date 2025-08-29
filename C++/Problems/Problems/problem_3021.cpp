#include "problem_3021.h"

bool problem_3021::test() {
    int n = 3;
    int m = 2;

    int expected = 3;

    auto result = flowerGame(n, m);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_3021::flowerGame(int n, int m) {
    long long nOdd = (n + 1) / 2;
    long long nEven = n / 2;
    long long mOdd = (m + 1) / 2;
    long long mEven = m / 2;

    return nOdd * mEven + nEven * mOdd;
}
