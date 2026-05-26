import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem539(Problem):
    def test(self) -> bool:
        timePoints = ["23:59", "00:00"]

        expected = 1

        result = self.findMinDifference(timePoints)

        print(result)

        return result == expected

    def findMinDifference(self, timePoints: List[str]) -> int:
        total = 24 * 60
        pres = [False] * total
        for t in timePoints:
            minutes = 600 * (ord(t[0]) - ord('0')) + 60 * (ord(t[1]) - ord('0')) + 10 * (ord(t[3]) - ord('0')) + (ord(t[4]) - ord('0'))
            if pres[minutes]:
                return 0
            pres[minutes] = True

        l = 0
        while not pres[l]:
            l += 1
        r = total - 1
        while not pres[r]:
            r -= 1
        result = l + total - r
        prev = l
        for i in range(l + 1, r + 1):
            if (pres[i]):
                result = min(result, i - prev)
                prev = i

        return result