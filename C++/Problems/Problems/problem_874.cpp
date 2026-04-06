#include "problem_874.h"

#include <set>
#include <unordered_set>

bool problem_874::test() {
    std::vector commands { 4, -1, 3 };
    std::vector<std::vector<int>> obstacles;

    int expected = 25;

    auto result = robotSim(commands, obstacles);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_874::robotSim(std::vector<int> &commands, std::vector<std::vector<int>> &obstacles) {
    std::set<std::pair<int, int>> obs;
    for (auto o : obstacles)
        obs.insert(std::pair(o[0], o[1]));
    std::vector<std::vector<int>> dirs { {0, 1}, {1, 0}, {0, -1}, {-1, 0} };
    int curDir = 0;
    int x = 0;
    int y = 0;
    int result = 0;
    for (auto cmd : commands)
    {
        if (cmd == -1)
            curDir = (curDir + 1) % 4;
        else if (cmd == -2)
            curDir = (curDir - 1 + 4) % 4;
        else
        {
            for (int i = 0; i < cmd; ++i)
            {
                x += dirs[curDir][0];
                y += dirs[curDir][1];
                if (obs.contains(std::pair(x, y)))
                {
                    x -= dirs[curDir][0];
                    y -= dirs[curDir][1];
                    break;
                }
                result = std::max(result, x * x + y * y);
            }
        }
    }
    return result;
}
