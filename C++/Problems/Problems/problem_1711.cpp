#include "problem_1711.h"

#include <unordered_map>

bool problem_1711::test() {
    std::vector deliciousness { 1, 3, 5, 7, 9 };

    int expected = 4;

    auto result = countPairs(deliciousness);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1711::countPairs(std::vector<int> &deliciousness) {
    std::vector<int> pows(22);
    pows[0] = 1;
    int b = 2;
    int mod = 1000000007;
    for (int i = 1; i <= 21; ++i)
    {
        pows[i] = b;
        b <<= 1;
    }
    std::unordered_map<int, int> counts;
    long long result = 0;
    for (auto d : deliciousness)
    {
        for (auto p : pows)
        {
            int exp = p - d;
            if (counts.contains(exp))
                result = (result + counts[exp]) % mod;
        }
        if (!counts.contains(d))
            counts[d] = 1;
        else
            counts[d]++;
    }

    return (int)result;
}
