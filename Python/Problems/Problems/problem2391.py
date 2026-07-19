import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2391(Problem):
    def test(self) -> bool:
        garbage = ["G", "P", "GP", "GG"]
        travel = [2, 4, 3]

        expected = 21

        result = self.garbageCollection(garbage, travel)

        print(result)

        return result == expected

    def garbageCollection(self, garbage: List[str], travel: List[int]) -> int:
        n = len(garbage)
        p = 0
        g = 0
        m = 0
        cur = 0
        coll = len(garbage[0])
        for i in range(1, n):
            coll += len(garbage[i])
            cur += travel[i - 1]
            for c in garbage[i]:
                if c == 'G':
                    g = cur
                elif c == 'P':
                    p = cur
                else:
                    m = cur

        return p + g + m + coll