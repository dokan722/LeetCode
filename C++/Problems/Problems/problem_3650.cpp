#include "problem_3650.h"

#include <queue>

bool problem_3650::test() {
    int n = 4;
    std::vector<std::vector<int>> edges { { 0, 1, 3 }, { 3, 1, 1 }, { 2, 3, 4 }, { 0, 2, 2 } };

    int expected = 5;

    auto result = minCost(n, edges);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3650::minCost(int n, std::vector<std::vector<int>> &edges) {
    std::priority_queue<std::pair<int, int>> queue;
    std::vector neighbours(n, std::vector<std::pair<int, int>>());
    std::vector dists(n, INT_MAX);
    for (auto edge : edges)
    {
        neighbours[edge[0]].push_back(std::pair(edge[1], edge[2]));
        neighbours[edge[1]].push_back(std::pair(edge[0], 2 * edge[2]));
    }

    queue.push(std::pair(0, 0));
    while (!queue.empty())
    {
        auto top = queue.top();
        queue.pop();
        auto cur = top.second;
        auto curDist = top.first;
        for (auto neighbour : neighbours[cur])
        {
            auto newDist = curDist + neighbour.second;
            if (newDist < dists[neighbour.first])
            {
                dists[neighbour.first] = newDist;
                queue.push(std::pair(newDist, neighbour.first));
            }
        }
    }

    return dists[n - 1] == INT_MAX ? -1 : dists[n - 1];
}
