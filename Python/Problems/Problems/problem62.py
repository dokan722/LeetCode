import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem62(Problem):
    def test(self) -> bool:
        m = 3
        n = 7

        expected = 28

        result = self.uniquePaths(m, n)

        print(result)

        return result == expected

    def uniquePaths(self, m: int, n: int) -> int:
        f = m + n - 2
        choose = min(m, n) - 1
        mod = 2000000000
        result = 1
        for i in range(1, choose + 1):
            result = result * (f - choose + i) // i % mod

        return result