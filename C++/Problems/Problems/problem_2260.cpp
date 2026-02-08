#include "problem_2260.h"

#include <unordered_map>

bool problem_2260::test() {
    std::vector cards { 3, 4, 2, 3, 4, 7 };

    int expected = 4;

    auto result = minimumCardPickup(cards);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2260::minimumCardPickup(std::vector<int> &cards) {
    int n = cards.size();
    std::unordered_map<int, int> pos;
    int result = INT_MAX;
    for (int i = 0; i < n; ++i)
    {
        if (pos.contains(cards[i]))
            result = std::min(result, i - pos[cards[i]] + 1);
        pos[cards[i]] = i;
    }

    return result == INT_MAX ? -1 : result;
}
