#include "problem_2079.h"

bool problem_2079::test() {
    std::vector plants { 3, 2, 4, 2, 1 };
    int capacity = 6;

    int expected = 17;

    auto result = wateringPlants(plants, capacity);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_2079::wateringPlants(std::vector<int> &plants, int capacity) {
    int n = plants.size();
    int curr = capacity;
    int result = n;
    for (int i = 0; i < n; i++)
    {
        if (curr < plants[i])
        {
            result += 2 * i;
            curr = capacity - plants[i];
        }
        else
            curr -= plants[i];
    }

    return result;
}
