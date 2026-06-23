#include "problem_3699.h"

bool problem_3699::test() {
    int n = 3;
    int l = 4;
    int r = 5;

    int expected = 2;

    auto result = zigZagArrays(n, l, r);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3699::zigZagArrays(int n, int l, int r) {
    std::vector dp0(r + 1, 0);
    std::vector dp1(r + 1, 0);
    std::vector sum0(r + 2, 0);
    std::vector sum1(r + 2, 0);
    int mod = 1000000007;


    for (int i = l; i <= r; i++)
    {
        dp0[i] = dp1[i] = 1;
        sum0[i] = sum1[i] = i - l + 1;
    }

    for (int i = 1; i < n; i++)
    {
        for (int j = l; j <= r; j++)
        {
            dp0[j] = (sum1[r] - sum1[j] + mod) % mod;
            dp1[j] = sum0[j - 1];
        }

        sum0[l] = dp0[l];
        sum1[l] = dp1[l];
        for (int j = l + 1; j <= r; j++)
        {
            sum0[j] = (sum0[j - 1] + dp0[j]) % mod;
            sum1[j] = (sum1[j - 1] + dp1[j]) % mod;
        }
    }

    return (sum0[r] + sum1[r]) % mod;
}
