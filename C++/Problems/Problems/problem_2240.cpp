#include "problem_2240.h"

bool problem_2240::test() {
    int total = 20;
    int cost1 = 10;
    int cost2 = 5;

    int expected = 9;

    auto result = waysToBuyPensPencils(total, cost1, cost2);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2240::waysToBuyPensPencils(int total, int cost1, int cost2) {
    long long result = 0;
    int big = std::max(cost1, cost2);
    int smol = std::min(cost1, cost2);
    for (int i = 0; i <= total / big; ++i)
    {
        result += (total - big * i) / smol + 1;
    }

    return result;
}
