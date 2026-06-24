#include "problem_667.h"

bool problem_667::test() {
    int n = 3;
    int k = 1;

    std::vector expected { 1, 2, 3 };

    auto result = constructArray(n, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_667::constructArray(int n, int k) {
    std::vector<int> result(n);
    int diff = n - k;
    result[0] = 1;
    for (int i = 1; i < diff; ++i)
        result[i] = result[i - 1] + 1;
    for (int i = 1; i <= k; ++i)
        result[diff + i - 1] = (i % 2 == 0) ? (n - k + i / 2) : (n - i / 2);
    return result;
}
