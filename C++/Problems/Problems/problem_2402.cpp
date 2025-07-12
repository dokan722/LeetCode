#include "problem_2402.h"

#include <algorithm>
#include <queue>

bool problem_2402::test() {
    std::vector<std::vector<int>> meetings { {0, 10},  {1, 6},  {2, 7},  {3, 4}};
    auto n = 2;

    auto expected = 0;

    auto result = mostBooked(n, meetings);

    std::cout << result << std::endl;

    return expected == result;
}

int problem_2402::mostBooked(int n, std::vector<std::vector<int>> &meetings) {
    std::vector<int> meetingCounts(n, 0);

    std::priority_queue<std::pair<long long, int>, std::vector<std::pair<long long, int>>, std::greater<>> usedRooms;
    std::priority_queue<int, std::vector<int>, std::greater<>> emptyRooms;
    for (int i = 0; i < n; ++i)
        emptyRooms.push(i);
    std::sort(meetings.begin(), meetings.end(), [](const std::vector<int> &a, const std::vector<int> &b) { return a[0] < b[0]; });
    for (auto meeting : meetings)
    {
        long long begin = meeting[0];
        long long end = meeting[1];
        int room;

        while (!usedRooms.empty() && usedRooms.top().first <= begin)
        {
            room = usedRooms.top().second;
            usedRooms.pop();
            emptyRooms.push(room);
        }


        if (!emptyRooms.empty())
        {
            room = emptyRooms.top();
            emptyRooms.pop();
            usedRooms.emplace(end, room);
        }
        else
        {
            auto [roomEnd, popRoom] = usedRooms.top();
            room = popRoom;
            usedRooms.pop();
            usedRooms.emplace(roomEnd + end - begin, room);
        }

        meetingCounts[room]++;
    }

    auto result = 0;
    auto maxCount = meetingCounts[0];
    for (int i = 1; i < n; ++i)
    {
        if (meetingCounts[i] > maxCount)
        {
            maxCount = meetingCounts[i];
            result = i;
        }
    }

    return result;
}
