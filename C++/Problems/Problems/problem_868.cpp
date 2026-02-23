#include "problem_868.h"

bool problem_868::test() {
    int n = 22;

    int expected = 2;

    auto result = binaryGap(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_868::binaryGap(int n) {
    if (std::popcount((unsigned)n) < 2)
        return 0;
    while (n % 2 == 0)
        n >>= 1;
    int result = 0;
    int count = 0;
    while (n != 0)
    {
        n >>= 1;
        if (n % 2 == 1)
        {
            result = std::max(result, count + 1);
            count = 0;
        }
        else
            count++;
    }

    return result;
}
