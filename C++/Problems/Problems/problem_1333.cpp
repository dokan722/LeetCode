#include "problem_1333.h"

#include <unordered_map>

bool problem_1333::test() {
    std::vector<std::vector<int>> restaurants  { {1, 4, 1, 40, 10},  {2, 8, 0, 50, 5}, {3, 8, 1, 30, 4},  {4, 10, 0, 10, 3},  {5, 1, 1, 15, 1}};
    int veganFriendly = 1;
    int maxPrice = 50;
    int maxDistance = 10;

    std::vector expected  { 3, 1, 5 };

    auto result = filterRestaurants(restaurants, veganFriendly, maxPrice, maxDistance);

    print1DVector(result);

    return expected == result;
}

std::vector<int> problem_1333::filterRestaurants(std::vector<std::vector<int>> &restaurants, int veganFriendly,
    int maxPrice, int maxDistance) {
    std::vector<int> result;
    std::pmr::unordered_map<int, int> ratings;
    for (auto r : restaurants)
    {
        if (veganFriendly == 1 && r[2] == 0)
            continue;
        if (r[3] <= maxPrice && r[4] <= maxDistance)
        {
            result.push_back(r[0]);
            ratings[r[0]] = r[1];
        }
    }

    std::sort(result.begin(), result.end(), [&](int a, int b) { return a == b ? a > b : ratings[a] > ratings[b]; });
    return result;
}
