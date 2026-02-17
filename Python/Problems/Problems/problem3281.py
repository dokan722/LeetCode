import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3281(Problem):
    def test(self) -> bool:
        start = [2, 6, 13, 13]
        d = 5

        expected = 5

        result = self.maxPossibleScore(start, d)

        print(result)

        return result == expected

    def maxPossibleScore(self, start: List[int], d: int) -> int:
        n = len(start)
        start.sort()
        l = sys.maxsize
        for i in range(1, n):
            l = min(l, start[i] - start[i - 1])
        r = l + d
        while l < r:
            mid = (l + r + 1) // 2
            poss = True
            curr = start[0]
            for i in range(1, n):
                gap = start[i] - curr
                if gap < mid:
                    missing = mid - gap
                    if missing > d:
                        poss = False
                        break
                    curr = start[i] + missing
            else:
                    curr = start[i]
            if poss:
                l = mid
            else:
                r = mid - 1

        return l