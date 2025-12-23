import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem2054(Problem):
    def test(self) -> bool:
        events = [[1, 3, 2], [4, 5, 2], [2, 4, 3]]

        expected = 4

        result = self.maxTwoEvents(events)

        print(result)

        return result == expected

    def maxTwoEvents(self, events: List[List[int]]) -> int:
        ts = []
        for e in events:
            ts.append((e[0], 0, e[2]))
            ts.append((e[1], 1, e[2]))

        result = 0
        maxFinished = 0
        ts.sort()
        for t in ts:
            if t[1] == 0:
                result = max(result, t[2] + maxFinished)
            else:
                maxFinished = max(maxFinished, t[2])

        return result