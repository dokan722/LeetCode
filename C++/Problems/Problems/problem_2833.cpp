#include "problem_2833.h"

bool problem_2833::test() {
    std::string moves = "L_RL__R";

    int expected = 3;

    auto result = furthestDistanceFromOrigin(moves);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2833::furthestDistanceFromOrigin(std::string moves) {
    int left = 0;
    int right = 0;
    int wild = 0;
    for (auto m : moves)
    {
        if (m == '_')
            wild++;
        else if (m == 'R')
            right++;
        else
            left++;
    }

    return std::abs(left - right) + wild;
}
