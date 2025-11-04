#include "problem_771.h"

#include <unordered_set>

bool problem_771::test() {
    std::string jewels = "aA";
    std::string stones = "aAAbbbb";

    int expected = 3;

    auto result = numJewelsInStones(jewels, stones);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_771::numJewelsInStones(std::string jewels, std::string stones) {
    std::unordered_set<char> jewelsSet;
    for (auto jewel : jewels)
        jewelsSet.insert(jewel);
    int result = 0;
    for (auto stone : stones)
        if (jewelsSet.contains(stone))
            result += 1;

    return result;
}
