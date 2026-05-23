#include "problem_789.h"

bool problem_789::test() {
    std::vector<std::vector<int>> ghosts { { 1, 0 }, { 0, 3 } };
    std::vector target { 0, 1 };

    bool expected = true;

    auto result = escapeGhosts(ghosts, target);

    return result == expected;
}

bool problem_789::escapeGhosts(std::vector<std::vector<int>> &ghosts, std::vector<int> &target) {
    int dist = std::abs(target[0]) + std::abs(target[1]);
    for (auto g : ghosts)
    {
        if (dist >= std::abs(target[0] - g[0]) + std::abs(target[1] - g[1]))
            return false;
    }

    return true;
}
