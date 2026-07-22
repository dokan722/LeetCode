import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2028(Problem):
    def test(self) -> bool:
        rolls = [3, 2, 4, 3]
        mean = 4
        n = 2

        expected = [6, 6]

        result = self.missingRolls(rolls, mean, n)

        print1DArray(result)

        return expected == result

    def missingRolls(self, rolls: List[int], mean: int, n: int) -> List[int]:
        m = len(rolls)
        req = (n + m) * mean
        for r in rolls:
            req -= r

        req -= n
        if req < 0:
            return []
        result = []
        for i in range(n):
            if (req <= 0):
                result.append(1)
            else:
                big = min(req, 5)
                result.append(big + 1)
                req -= big

        return result if req <= 0 else []