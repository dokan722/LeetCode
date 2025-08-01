#include "problem_3248.h"

bool problem_3248::test() {
    auto n = 2;
    std::vector<std::string> commands { "RIGHT", "DOWN" };

    auto expected = 3;

    auto result = finalPositionOfSnake(n, commands);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3248::finalPositionOfSnake(int n, std::vector<std::string> &commands) {
    auto x = 0;
    auto y = 0;
    for (const std::string& command : commands)
    {
        if (command == "RIGHT")
            y++;
        else if (command == "LEFT")
            y--;
        else if (command == "UP")
            x--;
        else
            x++;
    }

    return x * n + y;
}
