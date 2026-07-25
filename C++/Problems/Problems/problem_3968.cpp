#include "problem_3968.h"

bool problem_3968::test() {
    std::string moves = "L_D_";

    int expected = 4;

    auto result = maxDistance(moves);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3968::maxDistance(std::string moves) {
    int x = 0;
    int y = 0;
    int b = 0;
    for (auto m : moves)
    {
        if (m == 'U')
            x++;
        else if (m == 'D')
            x--;
        else if (m == 'R')
            y++;
        else if (m == 'L')
            y--;
        else
            b++;
    }

    return std::abs(x) + std::abs(y) + b;
}
