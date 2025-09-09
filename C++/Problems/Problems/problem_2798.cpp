#include "problem_2798.h"

bool problem_2798::test() {
    std::vector hours { 5, 1, 4, 2, 2 };
    int target = 6;

    int expected = 0;

    auto result = numberOfEmployeesWhoMetTarget(hours, target);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2798::numberOfEmployeesWhoMetTarget(std::vector<int> &hours, int target) {
    int result = 0;

    for (auto hour : hours)
        if (hour >= target)
            result++;

    return result;
}
