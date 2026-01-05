#include "problem_2672.h"

bool problem_2672::test() {
    int n = 4;
    std::vector<std::vector<int>> queries =  {  { 0, 2 },  { 1, 2 },  { 3, 1 },  { 1, 1 },  { 2, 1 } };

    std::vector expected =  { 0, 1, 1, 0, 2 };

    auto result = colorTheArray(n, queries);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_2672::colorTheArray(int n, std::vector<std::vector<int>> &queries) {
    int m = queries.size();
    int curr = 0;
    std::vector colors(n + 2, 0);
    std::vector<int> result(m);
    for (int i = 0; i < m; ++i)
    {
        const auto& query = queries[i];
        int id = query[0] + 1;
        if (colors[id] == query[1])
        {
            result[i] = curr;
            continue;
        }
        int prevL = (colors[id - 1] != 0 && colors[id] == colors[id - 1]) ? 1 : 0;
        int currL = (query[1] == colors[id - 1]) ? 1 : 0;
        int prevR = colors[id + 1] != 0 && (colors[id] == colors[id + 1]) ? 1 : 0;
        int currR = (query[1] == colors[id + 1]) ? 1 : 0;
        curr += currL + currR - prevL - prevR;
        colors[id] = query[1];
        result[i] = curr;
    }

    return result;
}
