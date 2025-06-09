#include "problem_440.h"

#include <iostream>
#include <algorithm>

bool problem_440::test() {
    auto n = 681692778;
    auto k = 351251360;

    auto expected = 416126219;

    auto result = findKthNumber(n, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_440::findKthNumber(int n, int k) {
    long curr = 1;
    long ka = k;
    long en = n;
    ka--;

    while (ka > 0)
    {
        long step = countSteps(en, curr, curr + 1);
        if (step <= ka)
        {
            curr++;
            ka -= step;
        }
        else
        {
            curr *= 10;
            ka--;
        }
    }

    return curr;
}

long problem_440::countSteps(long en, long long p1, long long p2) {
    long steps = 0;
    while (p1 <= en)
    {
        steps += std::min<long>(en + 1, p2) - p1;
        p1 *= 10;
        p2 *= 10;
    }
    return steps;
}
