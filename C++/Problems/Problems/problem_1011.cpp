#include "problem_1011.h"

bool problem_1011::test() {
    std::vector weights { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int days = 5;

    int expected = 15;

    auto result = shipWithinDays(weights, days);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1011::shipWithinDays(std::vector<int> &weights, int days) {
    int n = weights.size();
    int l = 0;
    int r = 0;
    for (auto num : weights)
    {
        l = std::max(num, l);
        r += num;
    }
    while (l < r)
    {
        int mid = (l + r) / 2;
        int cur = 0;
        for (int i = 0; i < days; ++i)
        {
            int pack = 0;
            while (cur < n && pack + weights[cur] <= mid)
            {
                pack += weights[cur];
                cur++;
            }
            if (cur >= n)
                break;
        }
        if (cur >= n)
            r = mid;
        else
            l = mid + 1;
    }

    return l;
}
