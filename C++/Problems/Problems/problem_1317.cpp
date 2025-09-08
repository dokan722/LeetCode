#include "problem_1317.h"

bool problem_1317::test() {
    int n = 2137;
    auto result = getNoZeroIntegers(n);

    return result[0] + result[1] == n;
}

std::vector<int> problem_1317::getNoZeroIntegers(int n) {
    std::vector result(2, 0);
    int mult = 1;
    while (n > 1)
    {
        int curr = n % 10;
        int rest = n / 10;
        if (curr > 1)
        {
            result[0] += 1 * mult;
            result[1] += (curr - 1) * mult;
        }
        else
        {
            curr += 10;
            rest -= 1;
            int part = curr / 2;
            result[0] += part * mult;
            result[1] += (curr - part) * mult;
        }

        n = rest;
        mult *= 10;
    }

    if (n == 1)
        result[0] += mult;

    return result;
}
