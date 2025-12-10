#include "problem_3577.h"

bool problem_3577::test() {
    std::vector complexity { 1, 2, 3 };

    int expected = 2;

    auto result = countPermutations(complexity);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3577::countPermutations(std::vector<int> &complexity) {
    int n = complexity.size();
    int mod = 1000000007;
    for (int i = 1; i < n; ++i)
    {
        if (complexity[i] <= complexity[0])
            return 0;
    }

    long long result = 1;
    for (int i = 1; i < n; ++i)
        result = (result * i) % mod;

    return (int)result;
}

