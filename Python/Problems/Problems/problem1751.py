from .problem import Problem


class Problem1751(Problem):
    def test(self):
        events = [[1, 2, 4], [3, 4, 3], [2, 3, 1]]

        k = 2

        expected = 7

        result = self.maxValue(events, k)

        print(result)

        return result == expected

    def maxValue(self, events, k):
        events.sort(key=lambda x: x[0])
        n = len(events)
        memory = [[-1] * n for _ in range(k + 1)]
        result = self.checkScheduleRec(events, memory, 0, k)

        return result

    def checkScheduleRec(self, events, memory, currEvent, k):
        if k == 0 or currEvent == len(events):
            return 0
        if memory[k][currEvent] != -1:
            return memory[k][currEvent]
        nextFree = events[currEvent][1] + 1
        left = currEvent
        right = len(events)
        while left < right:
            mid = (left + right) // 2
            if events[mid][0] < nextFree:
                left = mid + 1
            else:
                right = mid

        memory[k][currEvent] = max(events[currEvent][2] + self.checkScheduleRec(events, memory, left, k - 1),
                                        self.checkScheduleRec(events, memory, currEvent + 1, k))
        return memory[k][currEvent]