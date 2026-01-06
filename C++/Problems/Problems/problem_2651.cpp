#include "problem_2651.h"

bool problem_2651::test() {
    int arrivalTime = 15;
    int delayedTime = 5;

    int expected = 20;

    auto result = findDelayedArrivalTime(arrivalTime, delayedTime);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2651::findDelayedArrivalTime(int arrivalTime, int delayedTime) {
    return (arrivalTime + delayedTime) % 24;
}
