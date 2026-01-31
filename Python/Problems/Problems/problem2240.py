import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem2240(Problem):
    def test(self) -> bool:
        total = 20
        cost1 = 10
        cost2 = 5

        expected = 9

        result = self.waysToBuyPensPencils(total, cost1, cost2)

        print(result)

        return result == expected

    def waysToBuyPensPencils(self, total: int, cost1: int, cost2: int) -> int:
        result = 0
        big = max(cost1, cost2)
        smol = min(cost1, cost2)
        for i in range(total // big + 1):
            result += (total - big * i) // smol + 1

        return result