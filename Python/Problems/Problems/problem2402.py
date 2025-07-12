from .problem import Problem
import heapq


class Problem2402(Problem):
    def test(self):
        meetings = [[0,  10], [1, 6], [2, 7], [3, 4]]
        n = 2

        expected = 0

        result = self.mostBooked(n, meetings)

        print(result)

        return expected == result

    def mostBooked(self, n, meetings):
        meetingCounts = [0] * n

        usedRooms = []
        emptyRooms = []
        for i in range(n):
            heapq.heappush(emptyRooms, i)
        meetings.sort(key = lambda x: x[0])
        for meeting in meetings:
            begin = meeting[0]
            end = meeting[1]

            while usedRooms and usedRooms[0][0] <= begin:
                _, room = heapq.heappop(usedRooms)
                heapq.heappush(emptyRooms, room)


            if emptyRooms:
                room = heapq.heappop(emptyRooms)
                heapq.heappush(usedRooms, (end, room))
            else:
                priority, room  = heapq.heappop(usedRooms)
                heapq.heappush(usedRooms, (priority + end - begin, room))

            meetingCounts[room] += 1

        result = 0
        maxCount = meetingCounts[0]
        for i in range(n):
            if meetingCounts[i] > maxCount:
                maxCount = meetingCounts[i]
                result = i

        return result