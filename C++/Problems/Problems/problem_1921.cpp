#include "problem_1921.h"

bool problem_1921::test() {
    std::vector dist { 1, 3, 4 };
    std::vector speed { 1, 1, 1 };

    int expected = 3;

    auto result = eliminateMaximum(dist, speed);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1921::eliminateMaximum(std::vector<int> &dist, std::vector<int> &speed) {
    int n = dist.size();
    std::vector<int> turn(n);
    for (int i = 0; i < n; ++i)
    {
        turn[i] = (dist[i] + speed[i] - 1) / speed[i];
    }
    std::sort(turn.begin(), turn.end());
    for (int i = 0; i < n; ++i)
    {
        if (turn[i] < i + 1)
            return i;
    }

    return n;
}
