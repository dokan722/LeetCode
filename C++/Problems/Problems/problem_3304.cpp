#include "problem_3304.h"

#include <cmath>
#include <iostream>
#include <bits/ostream.tcc>

bool problem_3304::test() {
    auto k = 5;

    auto expected = 'b';

    auto result = kthCharacter(k);

    std::cout << result << std::endl;

    return result == expected;
}

char problem_3304::kthCharacter(int k) {
    int result = 0;
    int t;
    while (k != 1)
    {
        t = std::floor(std::log2(k));
        if ((1 << t) == k)
        {
            t--;
        }
        k -= (1 << t);
        result++;
    }
    return (char)('a' + result % 26);
}
