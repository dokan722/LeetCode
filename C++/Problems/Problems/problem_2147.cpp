#include "problem_2147.h"

bool problem_2147::test() {
    std::string corridor = "SSPPSPS";

    int expected = 3;

    auto result = numberOfWays(corridor);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2147::numberOfWays(std::string corridor) {
    int n = corridor.size();
    long long result = 1;
    int chairs = 0;
    int mod = 1000000007;
    for (int i = 0; i < n; i++)
    {
        if (corridor[i] == 'S')
            chairs++;
        if (chairs == 2)
        {
            int next = i + 1;
            while (next < n && corridor[next] != 'S')
                next++;
            if (next < n)
            {
                result = result * (next - i) % mod;
                i = next;
                chairs = 1;
            }
        }
    }

    if (chairs != 2)
        return 0;

    return (int)result;
}
