import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem3857(Problem):
    def test(self) -> bool:
        n = 3

        expected = 3

        result = self.minCost(n)

        print(result)

        return result == expected

    def minCost(self, n: int) -> int:
        return n * (n - 1) // 2