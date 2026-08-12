#include "problem_1686.h"

bool problem_1686::test() {
    std::vector aliceValues  { 1, 3 };
    std::vector bobValues  { 2, 1 };

    int expected = 1;

    auto result = stoneGameVI(aliceValues, bobValues);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1686::stoneGameVI(std::vector<int> &aliceValues, std::vector<int> &bobValues) {
    int n = aliceValues.size();
    std::vector counts(201, 0);
    int totalb = 0;
    for (int i = 0; i < n; ++i)
    {
        int s = aliceValues[i] + bobValues[i];
        counts[s]++;
        totalb += bobValues[i];
    }
    int turn = 0;
    int a = 0;
    for (int i = 200; i >= 0; --i)
    {
        int c = counts[i];
        a += i * ((c + (turn % 2 == 0 ? 1 : 0)) / 2);
        turn += c;
    }
    int res = a - totalb;
    if (res > 0)
        return 1;
    if (res < 0)
        return -1;
    return 0;
}
