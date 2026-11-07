#include "problem_849.h"

bool problem_849::test() {
    std::vector seats { 1, 0, 0, 0, 1, 0, 1 };

    int expected = 2;

    auto result = maxDistToClosest(seats);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_849::maxDistToClosest(std::vector<int> &seats) {
    int n = seats.size();
    int l = 0;
    int r = n - 1;
    while (seats[l] != 1)
        l++;
    while (seats[r] != 1)
        r--;
    int result = std::max(l, n - 1 - r);
    if (l != r)
    {
        int prev = l;
        for (int i = l + 1; i <= r; ++i)
        {
            if (seats[i] == 1)
            {
                int free = i - prev - 1;
                if (free > 0)
                    result = std::max(result, (free - 1) / 2 + 1);
                prev = i;
            }
        }
    }
    return result;
}
