import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3789(Problem):
    def test(self) -> bool:
        cost1 = 3
        cost2 = 2
        costBoth = 1
        need1 = 3
        need2 = 2

        expected = 3

        result = self.minimumCost(cost1, cost2, costBoth, need1, need2)

        print(result)

        return result == expected

    def minimumCost(self, cost1: int, cost2: int, costBoth: int, need1: int, need2: int) -> int:
        if costBoth < cost1 and costBoth < cost2:
            return costBoth * max(need1, need2)
        if cost1 + cost2 < costBoth:
            return cost1 * need1 + cost2 * need2
        if need1 < need2:
            return costBoth * need1 + min(costBoth, cost2) * (need2 - need1)
        return costBoth * need2 + min(costBoth, cost1) * (need1 - need2)