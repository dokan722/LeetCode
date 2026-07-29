import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem1744(Problem):
    def test(self) -> bool:
        candiesCount = [7, 4, 5, 3, 8]
        queries = [[0, 2, 2], [4, 2, 4], [2, 13, 1000000000]]

        expected = [True, False, True]

        result = self.canEat(candiesCount, queries)

        print1DArray(result)

        return expected == result

    def canEat(self, candiesCount: List[int], queries: List[List[int]]) -> List[bool]:
        n = len(candiesCount)
        pref = [0]
        for i in range(n):
            pref.append(pref[i] + candiesCount[i])
        m = len(queries)
        result = []
        for i in range(m):
            type = queries[i][0]
            day = queries[i][1] + 1
            cap = queries[i][2]
            if pref[type] < day * cap and pref[type + 1] >= day:
                result.append(True)
            else:
                result.append(False)

        return result