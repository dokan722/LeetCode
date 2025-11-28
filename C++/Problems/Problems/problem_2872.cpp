#include "problem_2872.h"

bool problem_2872::test() {
    int n = 5;
    std::vector<std::vector<int>> edges { { 0, 2 }, { 1, 2 }, { 1, 3 }, { 2, 4 } };
    std::vector values { 1, 8, 1, 4, 4 };
    int k = 6;

    int expected = 2;

    int result = maxKDivisibleComponents(n, edges, values, k);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2872::maxKDivisibleComponents(int n, std::vector<std::vector<int>> &edges, std::vector<int> &values,
    int k) {
    std::vector graph(n, std::vector<int>());
    for (auto edge : edges)
    {
        graph[edge[0]].push_back(edge[1]);
        graph[edge[1]].push_back(edge[0]);
    }

    dfs(0, -1, graph, values, k);

    return count;
}

int problem_2872::dfs(int e, int prev, std::vector<std::vector<int>>& graph, std::vector<int>& values, int k) {
    int sum = values[e];
    for (int n : graph[e])
    {
        if (n != prev)
            sum += dfs(n, e, graph, values, k);
        sum %= k;
    }

    if (sum % k == 0)
        count++;


    return sum;
}
