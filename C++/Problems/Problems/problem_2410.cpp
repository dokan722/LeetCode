#include "problem_2410.h"

#include <algorithm>

bool problem_2410::test() {
    std::vector players { 4, 7, 9 };
    std::vector trainers { 8, 2, 5, 8 };

    auto expected = 2;
    auto result = matchPlayersAndTrainers(players, trainers);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2410::matchPlayersAndTrainers(std::vector<int> &players, std::vector<int> &trainers) {
    std::sort(players.begin(), players.end());
    std::sort(trainers.begin(), trainers.end());
    int i = 0;
    int j = 0;
    auto result = 0;
    while (i < players.size() && j < trainers.size())
    {
        if (players[i] <= trainers[j])
        {
            result++;
            i++;
        }
        j++;
    }

    return result;
}
