import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem3638(Problem):
    def test(self) -> bool:
        weight = [2, 5, 1, 4, 3]

        expected = 2

        result = self.maxBalancedShipments(weight)

        print(result)

        return result == expected

    def maxBalancedShipments(self, weight: List[int]) -> int:
        result = 0
        m = 0
        for w in weight:
            m = max(m, w)
            if w < m:
                result += 1
                m = 0
        return result