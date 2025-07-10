import sys

from .problem import Problem

class Problem3440(Problem):
    def test(self):
        eventTime = 10
        startTime = [0, 3, 7, 9]
        endTime = [1, 4, 8, 10]

        expected = 6
        result = self.maxFreeTime(eventTime, startTime, endTime)

        print(result)

        return result == expected

    def maxFreeTime(self, eventTime, startTime, endTime):
        n = len(startTime)
        nGaps = n + 1
        sum = 0
        gaps = [0] * nGaps
        for i in range(nGaps):
            gaps[i] = self.getGapLength(i, startTime, endTime, eventTime)
        max1 = -sys.maxsize
        max2 = -sys.maxsize
        max3 = -sys.maxsize

        for gap in gaps:
            if gap > max1:
                max3 = max2
                max2 = max1
                max1 = gap
            elif gap > max2:
                max3 = max2
                max2 = gap
            elif gap > max3:
                max3 = gap

        result = 0
        for i in range(n):
            maxGap = max1
            if max(gaps[i], gaps[i + 1]) == max1:
                if min(gaps[i], gaps[i + 1]) == max2:
                    maxGap = max3
                else:
                    maxGap = max2
            currEvent = endTime[i] - startTime[i]
            freeTime = gaps[i] + gaps[i + 1] + currEvent if currEvent <= maxGap else gaps[i] + gaps[i + 1]
            if freeTime > result:
                result = freeTime

        return result


    def getGapLength(self, i, startTime, endTime, eventTime):
        if i == 0:
            return startTime[0]
        if i == len(startTime):
            return eventTime - endTime[-1]

        return startTime[i] - endTime[i - 1]