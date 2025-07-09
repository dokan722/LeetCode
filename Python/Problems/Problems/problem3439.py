from .problem import Problem

class Problem3439(Problem):
    def test(self):
        eventTime = 99
        k = 1
        startTime = [7, 21, 25]
        endTime = [13, 25, 78]

        expected = 21
        result = self.maxFreeTime(eventTime, k, startTime, endTime)

        print(result)

        return result == expected

    def maxFreeTime(self, eventTime, k, startTime, endTime):
        n = len(startTime)
        gaps = n + 1
        sum = 0
        for i in range(min(k + 1, gaps)):
            sum += self.getGapLength(i, startTime, endTime, eventTime);
        if (k >= n):
            return sum
        result = sum
        for i in range(gaps - k - 1):
            sum -= self.getGapLength(i, startTime, endTime, eventTime)
            sum += self.getGapLength(i + k + 1, startTime, endTime, eventTime)
            if sum > result:
                result = sum

        return result

    def getGapLength(self, i, startTime, endTime, eventTime):
        if i == 0:
            return startTime[0]
        if i == len(startTime):
            return eventTime - endTime[-1]

        return startTime[i] - endTime[i - 1]