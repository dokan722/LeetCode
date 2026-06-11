#include "problem_3558.h"

#include <queue>

bool problem_3558::test() {
    std::vector<std::vector<int>> edges { { 1, 2 }, { 1, 3 }, { 3, 4 }, { 3, 5 } };
    int expected = 2;

    auto result = assignEdgeWeights(edges);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3558::assignEdgeWeights(std::vector<std::vector<int>> &edges) {
    int n = edges.size() + 1;
    std::vector nbs(n + 1, std::vector<int>());
    for (auto& e : edges)
    {
        nbs[e[0]].push_back(e[1]);
        nbs[e[1]].push_back(e[0]);
    }

    int d = 0;
    std::queue<int> q;
    q.push(1);
    q.push(0);
    std::vector visited(n + 1, false);
    while (q.size() > 1)
    {
        int top = q.front();
        q.pop();
        if (top != 0)
        {
            visited[top] = true;
            for (auto nb : nbs[top])
            {
                if (!visited[nb])
                    q.push(nb);
            }
        }
        else
        {
            d++;
            q.push(0);
        }
    }
    long long res = 1;
    long long b = 2;
    int mod = 1000000007;
    d--;
    while (d > 0)
    {
        if (d % 2 == 1)
            res = res * b % mod;
        b = b * b % mod;
        d >>= 1;
    }

    return (int)res;
}
