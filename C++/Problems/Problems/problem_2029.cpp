#include "problem_2029.h"

bool problem_2029::test() {
    std::vector stones { 2, 1 };

    bool expected = true;

    auto result = stoneGameIX(stones);

    return expected == result;
}

bool problem_2029::stoneGameIX(std::vector<int> &stones) {
    std::vector counts(3, 0);
    for (auto stone : stones)
        counts[stone % 3]++;
    if (counts[0] % 2 == 0)
        return counts[1] >= 1 && counts[2] >= 1;
    return std::abs(counts[1] - counts[2]) > 2;
}
