#include "problem_3281.h"

#include <algorithm>

bool problem_3281::test() {
    std::vector start  { 2, 6, 13, 13 };
    int d = 5;

    int expected = 5;

    auto result = maxPossibleScore(start, d);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3281::maxPossibleScore(std::vector<int> &start, int d) {
    int n = start.size();
    std::sort(start.begin(), start.end());
    long long l = INT_MAX;
    for (int i = 1; i < n; ++i)
        l = std::min(l, (long long)start[i] - start[i - 1]);
    long long r = l + d;
    while (l < r)
    {
        long long mid = (l + r + 1) / 2;
        bool poss = true;
        long long curr = start[0];
        for (int i = 1; i < n; ++i)
        {
            long long gap = start[i] - curr;
            if (gap < mid)
            {
                long long missing = mid - gap;
                if (missing > d)
                {
                    poss = false;
                    break;
                }
                curr = start[i] + missing;
            }
            else
                curr = start[i];
        }
        if (poss)
            l = mid;
        else
            r = mid - 1;
    }

    return (int)l;
}
