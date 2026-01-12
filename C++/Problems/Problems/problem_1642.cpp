#include "problem_1642.h"

#include <queue>

bool problem_1642::test() {
    std::vector heights { 4, 2, 7, 6, 9, 14, 12 };
    int bricks = 5;
    int ladders = 1;

    int expected = 4;

    auto result = furthestBuilding(heights, bricks, ladders);

    std::cout << result << std::endl;

    return result == expected;
}

int problem_1642::furthestBuilding(std::vector<int> &heights, int bricks, int ladders) {
    int n = heights.size();
    std::priority_queue<int, std::vector<int>, std::greater<>> used;
    for (int i = 1; i < n; ++i)
    {
        int diff = heights[i] - heights[i - 1];
        if (diff <= 0)
            continue;
        if (ladders > 0)
        {
            used.push(diff);
            ladders--;
        }
        else if (!used.empty() && used.top() < diff)
        {
            auto h = used.top();
            used.pop();
            used.push(diff);
            bricks -= h;
        }
        else
            bricks -= diff;

        if (bricks < 0)
            return i - 1;
    }

    return n - 1;
}
