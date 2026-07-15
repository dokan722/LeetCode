#include "problem_1465.h"

bool problem_1465::test() {
    int h = 5;
    int w = 4;
    std::vector horizontalCuts { 1, 2, 4 };
    std::vector verticalCuts { 1, 3 };

    int expected = 4;

    auto result = maxArea(h, w, horizontalCuts, verticalCuts);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1465::maxArea(int h, int w, std::vector<int> &horizontalCuts, std::vector<int> &verticalCuts) {
    int n = horizontalCuts.size();
    int m = verticalCuts.size();
    std::sort(horizontalCuts.begin(), horizontalCuts.end());
    std::sort(verticalCuts.begin(), verticalCuts.end());
    int maxH = horizontalCuts[0];
    for (int i = 1; i < n; ++i)
        maxH = std::max(maxH, horizontalCuts[i] - horizontalCuts[i - 1]);
    maxH = std::max(maxH, h - horizontalCuts[n - 1]);
    int maxW = verticalCuts[0];
    for (int i = 1; i < m; ++i)
        maxW = std::max(maxW, verticalCuts[i] - verticalCuts[i - 1]);
    maxW = std::max(maxW, w - verticalCuts[m - 1]);

    return (int)((long long)maxH * maxW % 1000000007);
}
