#include "problem_3074.h"

#include <algorithm>

bool problem_3074::test() {
    std::vector apple { 1, 3, 2 };
    std::vector capacity { 4, 3, 1, 5, 2 };

    int expected = 2;

    auto result = minimumBoxes(apple, capacity);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_3074::minimumBoxes(std::vector<int> &apple, std::vector<int> &capacity) {
    int m = capacity.size();
    int appleSum = 0;
    for (auto a : apple)
        appleSum += a;
    std::sort(capacity.begin(), capacity.end());
    int i = m - 1;
    while (appleSum > 0)
    {
        appleSum -= capacity[i];
        i--;
    }

    return m - i - 1;
}
