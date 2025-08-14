#include "problem_1518.h"

bool problem_1518::test() {
    auto numBottles = 9;
    auto numExchange = 3;

    auto expected = 13;

    auto result = numWaterBottles(numBottles, numExchange);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1518::numWaterBottles(int numBottles, int numExchange) {
    auto result = 0;

    while (numBottles >= numExchange)
    {
        auto newBottles = numBottles / numExchange;
        auto remBottles = numBottles % numExchange;
        result += numBottles - remBottles;
        numBottles = remBottles + newBottles;
    }

    return result + numBottles;
}
