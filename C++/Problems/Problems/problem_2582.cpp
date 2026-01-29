#include "problem_2582.h"

bool problem_2582::test() {
    int n = 4;
    int time = 5;

    int expected = 2;

    auto result = passThePillow(n, time);



    return result == expected;
}

int problem_2582::passThePillow(int n, int time) {
    int even = (time / (n - 1)) % 2 == 0;
    return even ? (time % (n - 1)) + 1 : n - (time % (n - 1));
}
