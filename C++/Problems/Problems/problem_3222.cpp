#include "problem_3222.h"

bool problem_3222::test() {
    int x = 2;
    int y = 7;

    std::string expected = "Alice";

    auto result = winningPlayer(x, y);

    std::cout << result << std::endl;

    return expected == result;
}

std::string problem_3222::winningPlayer(int x, int y) {
    int yTurns = y / 4;
    return std::min(x, yTurns) % 2 == 0 ? "Bob" : "Alice";
}
