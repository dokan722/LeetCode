#include "problem_2943.h"

#include <algorithm>

bool problem_2943::test() {
    int n = 2;
    int m = 3;
    std::vector hBars { 2, 3 };
    std::vector vBars { 2, 4 };

    int expected = 4;

    auto result = maximizeSquareHoleArea(n, m, hBars, vBars);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2943::maximizeSquareHoleArea(int n, int m, std::vector<int> &hBars, std::vector<int> &vBars) {
    std::sort(hBars.begin(), hBars.end());
    std::sort(vBars.begin(), vBars.end());
    int hn = hBars.size();
    int vn = vBars.size();

    int curr = 1;
    int hm = 1;
    for (int i = 1; i < hn; ++i)
    {
        if (hBars[i] == hBars[i - 1] + 1)
            curr++;
        else
            curr = 1;
        hm = std::max(hm, curr);
    }

    curr = 1;
    int vm = 1;
    for (int i = 1; i < vn; ++i)
    {
        if (vBars[i] == vBars[i - 1] + 1)
            curr++;
        else
            curr = 1;
        vm = std::max(vm, curr);
    }

    int side = std::min(hm, vm) + 1;

    return side * side;
}
