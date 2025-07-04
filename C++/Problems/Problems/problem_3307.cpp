#include "problem_3307.h"

#include <cmath>
#include <iostream>
#include <ostream>

bool problem_3307::test() {
    auto k = 3;

    std::vector operations {1,0};

    auto expected = 'a';

    auto result = kthCharacter(k, operations);

    std::cout << result << std::endl;
    return result == expected;
}

char problem_3307::kthCharacter(long long k, std::vector<int> &operations) {
    int t;
    auto swaps = 0;
    while (k != 1)
    {
        t = std::floor(std::log2(k));
        if ((1L << t) == k)
        {
            t--;
        }
        k -= (1L << t);
        swaps += operations[t];
    }
    return (char)('a' + swaps % 26);
}
