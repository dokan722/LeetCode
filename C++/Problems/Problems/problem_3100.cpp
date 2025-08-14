#include "problem_3100.h"

bool problem_3100::test() {
    auto numBottles = 13;
    auto numExchange = 6;

    auto expected = 15;

    auto result = maxBottlesDrunk(numBottles, numExchange);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3100::maxBottlesDrunk(int numBottles, int numExchange) {
    auto result = 0;

    while (numBottles >= numExchange)
    {
        numBottles -= numExchange;
        result += numExchange;
        numBottles++;
        numExchange++;
    }

    return result + numBottles;
}
