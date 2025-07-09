#include "problem_1128.h"

bool problem_1128::test() {
    std::vector<std::vector<int>> dominoes { {1, 2}, {2, 1}, {3, 4}, {5, 6}};
    auto expected = 1;
    auto result = numEquivDominoPairs(dominoes);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1128::numEquivDominoPairs(std::vector<std::vector<int>> &dominoes) {
    int counts[100];
    auto result = 0;
    for (auto domino : dominoes)
    {
        auto id = domino[0] > domino[1] ? domino[0] * 10 + domino[1] : domino[1] * 10 + domino[0];
        result += counts[id];
        counts[id]++;
    }
    return result;
}
