#include "problem_2169.h"

bool problem_2169::test() {
    int num1 = 2;
    int num2 = 3;

    int expected = 3;

    auto result = countOperations(num1, num2);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2169::countOperations(int num1, int num2) {
    if (num1 < num2)
        return countOperations(num2, num1);
    if (num2 == 0)
        return 0;
    int ops = num1 / num2;
    int next = num1 % num2;
    return ops + countOperations(num2, next);
}
