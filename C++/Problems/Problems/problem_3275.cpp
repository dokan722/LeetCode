#include "problem_3275.h"

bool problem_3275::test() {
    std::vector<std::vector<int>> queries { { 1, 2 }, { 3, 4 }, { 2, 3 }, { -3, 0 } };
    int k = 2;

    std::vector expected { -1, 7, 5, 3 };

    auto result = resultsArray(queries, k);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3275::resultsArray(std::vector<std::vector<int>> &queries, int k) {
    int n = queries.size();
    std::priority_queue<int> heap;
    std::vector<int> result(n);
    for (int i = 0; i < n; ++i)
    {
        int dist = std::abs(queries[i][0]) + std::abs(queries[i][1]);
        if (heap.size() < k)
            heap.push(dist);
        else if (heap.top() > dist)
        {
            heap.pop();
            heap.push(dist);
        }
        result[i] = heap.size() == k ? heap.top() : -1;
    }

    return result;
}
