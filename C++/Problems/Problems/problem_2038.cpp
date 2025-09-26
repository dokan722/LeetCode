#include "problem_2038.h"

bool problem_2038::test() {
    std::string colors = "AAABABB";

    bool expected = true;

    auto result = winnerOfGame(colors);

    return expected == result;
}

bool problem_2038::winnerOfGame(std::string colors) {
    int n = colors.size();
    int aliceMoves = 0;
    int bobMoves = 0;
    for (int i = 1; i < n - 1; ++i)
    {
        if (colors[i - 1] == colors[i] && colors[i] == colors[i + 1])
        {
            if (colors[i] == 'A')
                aliceMoves++;
            else
                bobMoves++;
        }
    }

    return aliceMoves > bobMoves;
}
