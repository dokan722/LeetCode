#include "problem_2685.h"

#include <unordered_map>

bool problem_2685::test() {
    auto n = 6;
    std::vector<std::vector<int>> edges =  {  { 0, 1 },  { 0, 2 },  { 1, 2 },  { 3, 4 },  { 3, 5 } };

    auto expected = 1;

    auto result = countCompleteComponents(n, edges);

    return result == expected;
}

int problem_2685::countCompleteComponents(int n, std::vector<std::vector<int>> &edges) {
    findUnion fu(n);
    for (auto edge : edges)
    {
        fu.Union(edge[0], edge[1]);
    }

    std::pmr::unordered_map<int, int> counts;

    for (auto edge : edges)
    {
        auto root = fu.Find(edge[0]);
        if (counts.contains(root))
            counts[root]++;
        else
            counts[root] = 1;
    }

    auto result = 0;

    for (int i = 0; i < n; i++)
    {
        if (fu.Find(i) == i)
        {
            if (!counts.contains(i))
            {
                result++;
                continue;
            }
            auto verCount = fu.Counts[i];
            auto edgeCount = verCount * (verCount - 1) / 2;
            if (edgeCount == counts[i])
                result++;
        }
    }

    return result;
}

int findUnion::Find(int x) {
    if (_vertices[x] != -1)
    {
        _vertices[x] = Find(_vertices[x]);
        return _vertices[x];
    }
    return x;
}

void findUnion::Union(int x, int y) {
    auto root_x = Find(x);
    auto root_y = Find(y);
    if (root_x != root_y)
    {
        _vertices[root_x] = root_y;
        Counts[root_y] += Counts[root_x];
    }
}
