import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3502(Problem):
    def test(self) -> bool:
        cost = [5, 3, 4, 1, 3, 2]

        expected = [5, 3, 3, 1, 1, 1]

        result = self.minCosts(cost)

        print1DArray(result)

        return expected == result

    def minCosts(self, cost: List[int]) -> List[int]:
        n = len(cost)
        result = []
        m = cost[0]
        for i in range(n):
            m = min(m, cost[i])
            result.append(m)

        return result