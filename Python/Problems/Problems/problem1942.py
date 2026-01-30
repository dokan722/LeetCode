import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1942(Problem):
    def test(self) -> bool:
        times = [[33,35],[26,29],[9,28],[4,31],[8,10],[32,34],[15,24],[27,39],[14,36],[1,14],[25,39],[5,27],[6,15],[2,38],[19,36],[24,34],[3,26]]
        targetFriend = 0

        expected = 3

        result = self.smallestChair(times, targetFriend)

        print(result)

        return expected == result

    def smallestChair(self, times: List[List[int]], targetFriend: int) -> int:
        n = len(times)
        chairQueue = []
        occupiedChairs = []
        timesInOrder = [[i, times[i][0], times[i][1]] for i in range(n)]
        for i in range(n):
            heapq.heappush(chairQueue, i)
        timesInOrder.sort(key=lambda x: x[1])
        for i in range(n):
            cur = timesInOrder[i]
            while occupiedChairs and occupiedChairs[0][0] <= cur[1]:
                top = heapq.heappop(occupiedChairs)
                heapq.heappush(chairQueue, top[1])

            if cur[0] == targetFriend:
                break
            topChair = heapq.heappop(chairQueue)
            heapq.heappush(occupiedChairs, (cur[2], topChair))

        return chairQueue[0]