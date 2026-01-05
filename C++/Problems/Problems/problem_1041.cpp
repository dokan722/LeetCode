#include "problem_1041.h"

bool problem_1041::test() {
    std::string instructions = "GL";

    bool expected = true;

    auto result = isRobotBounded(instructions);

    return result == expected;
}

bool problem_1041::isRobotBounded(std::string instructions) {
    std::vector dirs(4, 0);
    int curr = 0;
    for (auto instruction : instructions)
    {
        if (instruction == 'G')
            dirs[curr]++;
        else if (instruction == 'R')
            curr = (curr + 1) % 4;
        else
            curr = (curr + 3) % 4;
    }


    return curr != 0 || dirs[0] == dirs[2] && dirs[1] == dirs[3];
}
