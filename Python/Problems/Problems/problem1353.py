from .problem import Problem


class Problem1353(Problem):
    def test(self):
        events = [[1, 1], [1, 4], [1, 10]]

        expected = 3

        result = self.maxEvents(events)

        print(result)

        return result == expected


    def maxEvents(self, events):
        events.sort(key=lambda x: x[1])
        maxDay = events[-1][1]
        schedule = [False] * (maxDay + 2)
        result = 0
        for e in events:
            for i in range(e[0], e[1] + 1):
                if not schedule[i]:
                    schedule[i] = True
                    result += 1
                    break


        return result