#include "problem_2528.h"

bool problem_2528::test() {
    std::vector stations { 4, 2 };
    int r = 1;
    int k = 1;

    int expected = 7;

    auto result = maxPower(stations, r, k);

    std::cout << result << std::endl;

    return result == expected;
}

long long problem_2528::maxPower(std::vector<int> &stations, int r, int k) {
    int n = stations.size();
    long long l = INT_MAX;
    long long h = INT_MIN;
    std::vector<long long> diff(n, 0);
    for (int i = 0; i < n; i++)
    {
        long long station = stations[i];
        l = std::min(l, station);
        if (i >= r)
            diff[i - r] += station;
        else
            diff[0] += station;
        if (i + r + 1 < n)
            diff[i + r + 1] -= station;
    }

    long long currStations = 0;
    for (int i = 0; i < n; ++i)
    {
        currStations += diff[i];
        h = std::max(h, currStations);
    }

    h += k;
    while (l < h)
    {
        long m = (l + h + 1) / 2;
        std::vector<long long> ranges(n, 0);
        bool poss = true;
        long long preSum = 0;
        long long rem = k;
        for (int i = 0; i < n; ++i)
        {
            preSum += diff[i];
            preSum += ranges[i];
            if (preSum < m)
            {
                long long newStations = m - preSum;
                rem -= newStations;
                preSum += newStations;
                if (i + 2 * r + 1 < n)
                    ranges[i + 2 * r + 1] -= newStations;
            }

            if (rem < 0)
            {
                poss = false;
                break;
            }
        }

        if (poss)
            l = m;
        else
            h = m - 1;
    }

    return l;
}
