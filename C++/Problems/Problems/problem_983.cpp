#include "problem_983.h"

bool problem_983::test() {
    std::vector days { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 30, 31 };
    std::vector costs { 2, 7, 15 };

    auto expected = 17;

    auto result = mincostTickets(days, costs);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_983::mincostTickets(std::vector<int> &days, std::vector<int> &costs) {
    auto maxDay = days[days.size() - 1];
    std::vector<int> dailyCosts(maxDay + 1, 0);
    auto nextTravel = 0;
    auto prevDay = 0;
    for (int i = 1; i <= maxDay; i++)
    {
        if (i == days[nextTravel])
        {
            dailyCosts[i] =
                std::min(std::min(dailyCosts[i - 1] + costs[0], dailyCosts[std::max(0, i - 7)] + costs[1]),
                    dailyCosts[std::max(0, i - 30)] + costs[2]);
            prevDay = dailyCosts[i];
            nextTravel++;
        }
        else
        {
            dailyCosts[i] = prevDay;
        }
    }

    return dailyCosts[maxDay];
}
