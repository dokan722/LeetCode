#include "problem_1386.h"

#include <unordered_map>

bool problem_1386::test() {
    int n = 3;
    std::vector<std::vector<int>> reservedSeats =  { { 1, 2 }, { 1, 3 }, { 1, 8 }, { 2, 6 }, { 3, 1 }, { 3, 10 } };

    int expected = 4;

    auto result = maxNumberOfFamilies(n, reservedSeats);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1386::maxNumberOfFamilies(int n, std::vector<std::vector<int>> &reservedSeats) {
    std::unordered_map<int, int> occupied;
    for (auto r : reservedSeats)
    {
        int cur;
        if (occupied.contains(r[0]))
            cur = occupied[r[0]];
        else
            cur = 7;
        if (r[1] > 1 && r[1] < 6)
            cur &= 6;
        if (r[1] > 3 && r[1] < 8)
            cur &= 5;
        if (r[1] > 5 && r[1] < 10)
            cur &= 3;
        occupied[r[0]] = cur;
    }
    int result = 2 * n;
    for (auto row : occupied)
    {
        int state = row.second;
        if (state == 0)
            result -= 2;
        else if (state != 7 && state != 5)
            result -= 1;
    }

    return result;
}
