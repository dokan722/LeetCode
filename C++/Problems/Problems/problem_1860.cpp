#include "problem_1860.h"

bool problem_1860::test() {
    int memory1 = 8;
    int memory2 = 11;

    std::vector expected { 6, 0, 4 };

    auto result = memLeak(memory1, memory2);

    print1DVector(result);

    return result == expected;
}

std::vector<int> problem_1860::memLeak(int memory1, int memory2) {
    long long n = (long long)memory1 + memory2 + 2;
    for (int i = 1; i < n; ++i)
    {
        if (memory1 >= memory2)
        {
            if (memory1 < i)
                return std::vector { i, memory1, memory2 };
            memory1 -= i;
        }
        else
        {
            if (memory2 < i)
                return std::vector { i, memory1, memory2 };
            memory2 -= i;
        }
    }

    return std::vector<int> {};
}
