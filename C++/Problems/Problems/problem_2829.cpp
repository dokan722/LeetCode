#include "problem_2829.h"

bool problem_2829::test() {
    int n = 5;
    int k = 4;

    int expected = 18;

    auto result = minimumSum(n, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2829::minimumSum(int n, int k) {
    int half = k / 2;
    if (k < 3 || half > n)
        return n * (n + 1) / 2;
    int end = n + (k - half);
    return half * (half + 1) / 2 - k * (k - 1) / 2 + end * (end - 1) / 2;
}
