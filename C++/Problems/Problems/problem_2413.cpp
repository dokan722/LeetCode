#include "problem_2413.h"

bool problem_2413::test() {
    int n = 5;

    int expected = 10;

    auto result = smallestEvenMultiple(n);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2413::smallestEvenMultiple(int n) {
    if (n % 2 == 0)
        return n;
    return 2 * n;
}
