#include "problem_657.h"

bool problem_657::test() {
    std::string moves = "UD";

    bool expected = true;

    auto result = judgeCircle(moves);

    return expected == result;
}

bool problem_657::judgeCircle(std::string moves) {
    int x = 0;
    int y = 0;
    for (auto move : moves)
    {
        if (move == 'U')
            x++;
        else if (move == 'D')
            x--;
        else if (move == 'L')
            y++;
        else if (move == 'R')
            y--;
    }

    return x == 0 && y == 0;
}
