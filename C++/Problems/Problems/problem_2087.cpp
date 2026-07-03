#include "problem_2087.h"

bool problem_2087::test() {
    std::vector startPos  { 1, 0 };
    std::vector homePos { 2, 3 };
    std::vector rowCosts { 5, 4, 3 };
    std::vector colCosts { 8, 2, 6, 7 };

    int expected = 18;

    auto result = minCost(startPos, homePos, rowCosts, colCosts);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2087::minCost(std::vector<int> &startPos, std::vector<int> &homePos, std::vector<int> &rowCosts,
    std::vector<int> &colCosts) {
    int result = rowCosts[homePos[0]] + colCosts[homePos[1]] - rowCosts[startPos[0]] - colCosts[startPos[1]];
    int it = startPos[0] <= homePos[0] ? 1 : -1;
    for (int i = startPos[0]; i != homePos[0]; i += it)
        result += rowCosts[i];
    it = startPos[1] <= homePos[1] ? 1 : -1;
    for (int i = startPos[1]; i != homePos[1]; i += it)
        result += colCosts[i];
    return result;
}
