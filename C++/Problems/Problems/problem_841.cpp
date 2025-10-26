#include "problem_841.h"

#include <stack>

bool problem_841::test() {
    std::vector<std::vector<int>> rooms { {1}, {2}, {3}, {} };

    bool expected = true;

    auto result = canVisitAllRooms(rooms);

    return expected == result;
}

bool problem_841::canVisitAllRooms(std::vector<std::vector<int>> &rooms) {
    int n = rooms.size();
    int covered = 0;
    std::vector visited(n, false);
    std::stack<int> toVisit;
    toVisit.push(0);
    while (!toVisit.empty())
    {
        auto next  = toVisit.top();
        toVisit.pop();
        if (visited[next])
            continue;
        covered++;
        visited[next] = true;
        for (auto key : rooms[next])
        {
            if (!visited[key])
                toVisit.push(key);
        }
    }

    return covered == n;
}
