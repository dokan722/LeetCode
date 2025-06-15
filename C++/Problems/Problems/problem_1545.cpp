#include "problem_1545.h"

#include <iostream>
#include <ostream>

bool problem_1545::test() {
    auto n = 3;

    auto k = 7;

    auto expected = '1';

    auto result = findKthBit(n, k);

    std::cout << result << std::endl;

    return expected == result;
}

char problem_1545::findKthBit(int n, int k) {
    if (n == 1)
        return '0';

    auto sLen = (1 << n);
    auto half = sLen / 2;

    if (k < half)
        return findKthBit(n - 1, k);

    if (k == sLen / 2)
        return '1';

    return findKthBit(n - 1, sLen - k) == '1' ? '0' : '1';
}
