#include "problem_2975.h"

#include <unordered_set>

bool problem_2975::test() {
    int m = 4;
    int n = 3;
    std::vector hFences { 2, 3 };
    std::vector vFences { 2 };

    int expected = 4;

    auto result = maximizeSquareArea(m, n, hFences, vFences);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2975::maximizeSquareArea(int m, int n, std::vector<int> &hFences, std::vector<int> &vFences) {
    int hn = hFences.size();
    std::unordered_set<int> hDists;
    hDists.insert(m - 1);
    for (int i = 0; i < hn; ++i)
    {
        for (int j = i + 1; j < hn; ++j)
            hDists.insert(std::abs(hFences[i] - hFences[j]));
        hDists.insert(std::abs(1 - hFences[i]));
        hDists.insert(std::abs(m - hFences[i]));
    }
    int vn = vFences.size();
    std::unordered_set<int> vDists;
    vDists.insert(n - 1);
    for (int i = 0; i < vn; ++i)
    {
        for (int j = i + 1; j < vn; ++j)
            vDists.insert(std::abs(vFences[i] - vFences[j]));
        vDists.insert(std::abs(1 - vFences[i]));
        vDists.insert(std::abs(m - vFences[i]));
    }

    int side = 0;
    for (auto hDist : hDists)
    {
        if (vDists.contains(hDist))
            side = std::max(side, hDist);
    }

    return side == 0 ? -1 : (int)((long)side * side % 1000000007);
}
