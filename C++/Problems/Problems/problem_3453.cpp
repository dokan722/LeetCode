#include "problem_3453.h"

#include <float.h>

bool problem_3453::test() {
    std::vector<std::vector<int>> squares { { 0, 0, 2 }, { 1, 1, 1 } };

    double expected = 1.16667;

    double result = separateSquares(squares);

    std::cout << result << std::endl;

    return std::abs(result - expected) < 1e-5;
}

double problem_3453::separateSquares(std::vector<std::vector<int>> &squares) {
    double bot = DBL_MAX;
    double top = DBL_MIN;

    for (auto &square : squares)
    {
        bot = std::min(bot, (double)square[1]);
        top = std::max(top, (double)square[1] + square[2]);
    }

    while (std::abs(bot - top) > 1e-5)
    {
        double mid = (bot + top) / 2;
        double below = 0;
        double above = 0;
        for (auto &square : squares)
        {
            double z = std::max(0.0, std::min((double)square[2], mid - square[1]));
            below += z * square[2];
            above += (square[2] - z) * square[2];
        }

        if (below >= above)
            top = mid;
        else
            bot = mid;
    }

    return bot;
}
