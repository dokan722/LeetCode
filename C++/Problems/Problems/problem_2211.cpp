#include "problem_2211.h"

bool problem_2211::test() {
    std::string directions = "RLRSLL";

    int expected = 5;

    auto result = countCollisions(directions);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2211::countCollisions(std::string directions) {
    int n = directions.size();
    int start = 0, end = n - 1;
    while (start < n && directions[start] == 'L')
        start++;
    while (end >= 0 && directions[end] == 'R')
        end--;
    int result = 0;
    for (int i = start; i <= end;  i++)
        if (directions[i] != 'S')
            result++;
    return result;
}
