#include "problem_1743.h"

bool problem_1743::test() {
    std::vector<std::vector<int>> adjacentPairs {  { 2, 1 },  { 3, 4 },  { 3, 2 } };

    std::vector expected { 1, 2, 3, 4 };

    auto result = restoreArray(adjacentPairs);


    return result == expected;
}

std::vector<int> problem_1743::restoreArray(std::vector<std::vector<int>> &adjacentPairs) {
    std::unordered_map<int, std::vector<int>> graph;
    for (auto pair : adjacentPairs)
    {
        if (graph.contains(pair[0]))
            graph[pair[0]].push_back(pair[1]);
        else
            graph[pair[0]] = std::vector { pair[1] } ;
        if (graph.contains(pair[1]))
            graph[pair[1]].push_back(pair[0]);
        else
            graph[pair[1]] = std::vector { pair[0] };
    }

    int root;
    for (auto v : graph)
        if (v.second.size() == 1) {
            root = v.first;
            break;
        }
    std::vector result { root };
    dfsListGraph(graph, root, -1, result);


    return result;
}

void problem_1743::dfsListGraph(std::unordered_map<int, std::vector<int>> &graph, int curr, int prev,
    std::vector<int> &result) {
    for (auto n : graph[curr])
    {
        if (n != prev)
        {
            result.push_back(n);
            dfsListGraph(graph, n, curr, result);
        }
    }
}
