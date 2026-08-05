#include "problem_3310.h"

bool problem_3310::test() {
    int n = 4;
    int k = 1;
    std::vector<std::vector<int>> invocations { { 1, 2 },  { 0, 1 },  { 3, 2 } };

    std::vector expected  { 0, 1, 2, 3 };

    auto result = remainingMethods(n, k, invocations);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_3310::remainingMethods(int n, int k, std::vector<std::vector<int>> &invocations) {
    std::vector nig(n, std::vector<int>());
    for (auto i : invocations)
    {
        nig[i[0]].push_back(i[1]);
    }
    std::vector sus(n , false);
    std::queue<int> q;
    q.push(k);
    while (!q.empty())
    {
        int next = q.front();
        q.pop();
        sus[next] = true;
        for (auto ni : nig[next])
        {
            if (!sus[ni])
                q.push(ni);
        }
    }
    std::vector<int> result;
    for (int i = 0; i < n; ++i)
    {
        if (sus[i])
            continue;
        for (auto ni : nig[i])
        {
            if (sus[ni]) {
                std::vector<int> res(n);
                for (int j = 0; j < n; ++j)
                    res[j] = j;
                return res;
            }
        }
        result.push_back(i);
    }

    return result;
}
