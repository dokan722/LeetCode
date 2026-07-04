#include "problem_2492.h"

bool problem_2492::test() {
    int n = 4;
    std::vector<std::vector<int>> roads  { { 1, 2, 9 }, { 2, 3, 6 }, { 2, 4, 5 }, { 1, 4, 7 } };

    int expected = 5;

    auto result = minScore(n, roads);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2492::minScore(int n, std::vector<std::vector<int>> &roads) {
    std::vector ngs(n, std::vector<int>());
    std::vector edges(n, std::vector<int>());
    for (auto& r : roads)
    {
        int a = r[0] - 1;
        int b = r[1] - 1;
        ngs[a].push_back(b);
        edges[a].push_back(r[2]);
        ngs[b].push_back(a);
        edges[b].push_back(r[2]);
    }
    std::vector visited(n, false);
    std::queue<int> queue;
    queue.push(0);
    visited[0] = true;
    int result = INT_MAX;
    while (!queue.empty())
    {
        int top = queue.front();
        queue.pop();
        int ct = ngs[top].size();
        for (int i = 0; i < ct; ++i)
        {
            int ng = ngs[top][i];
            int edge = edges[top][i];
            result = std::min(result, edge);
            if (!visited[ng])
            {
                queue.push(ng);
                visited[ng] = true;
            }
        }
    }

    return result;
}
