#include "problem_1942.h"

#include <algorithm>
#include <queue>

bool problem_1942::test() {
    std::vector<std::vector<int>> times =
    {
         { 33, 35 },  { 26, 29 },  { 9, 28 },  { 4, 31 },  { 8, 10 },  { 32, 34 },
         { 15, 24 },  { 27, 39 },  { 14, 36 },  { 1, 14 },  { 25, 39 },
         { 5, 27 },  { 6, 15 },  { 2, 38 },  { 19, 36 },  { 24, 34 },  { 3, 26 }
    };
    int targetFriend = 0;

    int expected = 3;

    auto result = smallestChair(times, targetFriend);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_1942::smallestChair(std::vector<std::vector<int>> &times, int targetFriend) {
    int n = times.size();
    std::priority_queue<int, std::vector<int>, std::greater<>> chairQueue;
    std::priority_queue<std::pair<int, int>, std::vector<std::pair<int, int>>, std::greater<>> occupiedChairs;
    std::vector<std::pair<int, int>> order;
    for (int i = 0; i < n; ++i) {
        chairQueue.push(i);
        order.push_back({times[i][0], i});
    }
    std::sort(order.begin(), order.end());
    for (int i = 0; i < n; ++i)
    {
        auto cur = times[order[i].second];
        while (!occupiedChairs.empty() && occupiedChairs.top().first <= cur[0])
        {
            auto chair = occupiedChairs.top().second;
            occupiedChairs.pop();
            chairQueue.push(chair);
        }
        if (order[i].second == targetFriend)
            break;
        int topChair = chairQueue.top();
        chairQueue.pop();
        occupiedChairs.push(std::pair(cur[1], topChair));
    }

    return chairQueue.top();
}