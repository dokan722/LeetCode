#include "problem_1492.h"

#include <cmath>

bool problem_1492::test() {
    int n = 12;
    int k = 3;

    int expected = 3;

    auto result = kthFactor(n, k);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1492::kthFactor(int n, int k) {
    double limit = std::sqrt(n);
    for (int i = 1; i < limit; ++i)
    {
        if (n % i == 0)
        {
            k--;
            if (k == 0)
                return i;
        }

    }


    for (int i = (int)limit; i > 0; --i)
    {
        int div = n / i;
        if (n % div == 0)
        {
            k--;
            if (k == 0)
                return div;
        }

    }

    return -1;
}
