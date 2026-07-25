#include "problem_3536.h"

bool problem_3536::test() {
    int n = 31;

    int expected = 3;

    auto result = maxProduct(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3536::maxProduct(int n) {
    int mx = 0;
    int mx2 = 0;
    while (n > 0)
    {
        int d = n % 10;
        n /= 10;
        if (d >= mx)
        {
            mx2 = mx;
            mx = d;
        }
        else if (d > mx2)
            mx2 = d;
    }
    return mx * mx2;
}
