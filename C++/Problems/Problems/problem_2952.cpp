#include "problem_2952.h"

bool problem_2952::test() {
    std::vector coins { 1, 4, 10 };
    int target = 19;

    int expected = 2;

    auto result = minimumAddedCoins(coins, target);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2952::minimumAddedCoins(std::vector<int> &coins, int target) {
    int n = coins.size();
    int result = 0;
    int mx = 0;
    std::sort(coins.begin(), coins.end());
    int i = 0;
    while (mx < target)
    {
        if (i < n && coins[i] <= mx + 1)
        {
            mx += coins[i];
            i++;
        }
        else
        {
            result++;
            mx += mx + 1;
        }
    }

    return result;
}
